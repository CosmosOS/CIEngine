using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Cosmos.CIEngine.Data;
using Newtonsoft.Json;

namespace Cosmos.CIEngine
{
    partial class Engine
    {
        private const string GithubPollingETagConfigName = "PreviousEtag";

        private async Task RetrieveAndParseGithubEvents()
        {
            using (var xCtx = new DataContext())
            {
                var xGithub = ConnectToGithub();

                var xPreviousETag = xCtx.TryGetConfigStr(GithubPollingETagConfigName);

                var xResult = await xGithub.GetEventsForRepositoryAsync(GithubOrganisation, GithubRepository, xPreviousETag);
                Console.WriteLine("Returned {0} items", xResult.Item1.Count);
                foreach (var xItem in xResult.Item1)
                {
                    var xEvent = xCtx.Events.SingleOrDefault(i => i.EventId == xItem.id);
                    if (xEvent != null)
                    {
                        continue;
                    }

                    xEvent = new EventObj();
                    xEvent.Identifier = Guid.NewGuid();
                    xEvent.Actor = xItem.actor.url;
                    xEvent.Organisation = xItem.org.url;
                    xEvent.Repository = xItem.repo.url;

                    xEvent.EventId = xItem.id;
                    xEvent.Type = xItem.type;
                    xEvent.CreatedAt = xItem.created_at;
                    xEvent.Payload = JsonConvert.SerializeObject(xItem.payload);
                    xCtx.Events.Add(xEvent);
                    xCtx.SaveChanges();
                }

                xCtx.SetConfigStr(GithubPollingETagConfigName, xResult.Item2);
                xCtx.SaveChanges();
            }
        }
    }
}

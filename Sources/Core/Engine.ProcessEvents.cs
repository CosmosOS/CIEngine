using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Xsl;
using Cosmos.CIEngine.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cosmos.CIEngine
{
    partial class Engine
    {
        private async Task ProcessRetrievedEventsAsync()
        {
            bool xAnythingHandled;
            do
            {
                xAnythingHandled = false;
                using (var xCtx = new DataContext())
                {
                    foreach (var xEvent in (from item in xCtx.Events
                                            where !item.Processed
                                            orderby item.CreatedAt
                                            select item).Take(50).ToArray())
                    {
                        if (!ShouldSkipEvent(xEvent.Type))
                        {
                            var xPayload = JsonConvert.DeserializeObject<JObject>(xEvent.Payload);
                            switch (xEvent.Type.ToLower())
                            {
                                case "pushevent":
                                    HandleRetrievedPushEvent(xCtx, xEvent, xPayload);
                                    break;
                                case "pullrequestevent":
                                    HandleRetrievedPullRequestEvent(xCtx, xEvent, xPayload);
                                    break;
                                default:
                                    throw new Exception("Event not handled: '" + xEvent.Type + "'!");
                            }
                        }
                        //xEvent.Processed = true;
                        await xCtx.SaveChangesAsync();
                        // to handle:

                        //- PushEvent
                        //- PullRequestEvent
                        //xAnythingHandled = true;
                    }
                }
            }
            while (xAnythingHandled);
        }

        private void HandleRetrievedPushEvent(DataContext ctx, EventObj eventObj, JObject payload)
        {
            //var xHeadHash = payload["head"].ToString();
            //var xBuild = new BuildObj();
            //xBuild.Identifier = Guid.NewGuid();
            //xBuild.RelatedEventId = eventObj.Identifier;
            //xBuild.EnqueueTime = DateTime.UtcNow;
            //xBuild.SourceVersionSha1 = xHeadHash;
            //xBuild.State = BuildStateEnum.Queued;
            //ctx.Builds.Add(xBuild);
            //Console.Write("");
            //
        }

        private void HandleRetrievedPullRequestEvent(DataContext ctx, EventObj eventObj, JObject payload)
        {
            //var xAction = payload["action"];

        }

        // for details, see https://developer.github.com/v3/activity/events/types/
        private static readonly string[] mEventsToSkip = new string[]
                                                         {
                                                             "CommitCommentEvent",
                                                             // should we include this one?? It'Happens for createed branches or tags
                                                             "CreateEvent",
                                                             "DeleteEvent",
                                                             "DeploymentEvent",
                                                             "DeploymentStatusEvent",
                                                             "ForkEvent",
                                                             "GollumEvent",
                                                             "IssueCommentEvent",
                                                             "IssuesEvent",
                                                             "MemberEvent",
                                                             "MembershipEvent",
                                                             "PageBuildEvent",
                                                             "PullRequestReviewCommentEvent",
                                                             "Push",
                                                             "ReleaseEvent",
                                                             "RepositoryEvent",
                                                             "StatusEvent",
                                                             "TeamAddEvent",
                                                             "WatchEvent"
                                                         };
        private static bool ShouldSkipEvent(string eventName)
        {
            return mEventsToSkip.Contains(eventName, StringComparer.OrdinalIgnoreCase);
        }
    }
}

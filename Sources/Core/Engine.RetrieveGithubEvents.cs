using System;
using System.Threading.Tasks;

namespace Cosmos.CIEngine
{
    partial class Engine
    {

        private async Task RetrieveAndParseGithubEvents()
        {
            var xConnection = ConnectToGithub();
            var xResult = await xConnection.GetEventsForRepositoryAsync("CosmosOS", "Cosmos", null);
            Console.WriteLine("First time: {0} events", xResult.Item1.Count);
            xResult = await xConnection.GetEventsForRepositoryAsync("CosmosOS", "Cosmos", xResult.Item2);
            Console.WriteLine("Second time: {0} events", xResult.Item1.Count);

            Console.Write("");

        }
    }
}

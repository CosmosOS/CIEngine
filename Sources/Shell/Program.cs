using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.CIEngine.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting Cosmos CI Engine");
                var xEngine = new Engine();

                // for now hardcode configuration:
                xEngine.GithubOrganisation = "CosmosOS";
                xEngine.GithubRepository = "CIEngine";
                //xEngine.GithubRepository = "Cosmos";

                xEngine.HandleError = e => Console.WriteLine("Error occurred in engine: " + e.ToString());
                xEngine.Start();
                //Console.WriteLine("Started. Press enter to exit");
                //xEngine.Stop();
            }
            catch (Exception E)
            {
                Console.WriteLine("Error occurred: " + E.ToString());
            }
        }
    }
}

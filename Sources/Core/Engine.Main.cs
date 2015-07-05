using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cosmos.CIEngine
{
    partial class Engine
    {
        private const int EngineSleepTimeMsecs = 1 * 60 * 1000; // for now, wait 60 seconds after each run.

        private void EngineMain()
        {
            Task.WaitAll(EngineMainAsync());
        }

        private async Task EngineMainAsync()
        {
            try
            {
                while (true)
                {
                    //await RetrieveAndParseGithubEventsAsync();

                    //DumpItems();

                    //await ProcessRetrievedEventsAsync();


                    //Thread.Sleep(EngineSleepTimeMsecs);
                    break;
                }
            }
            catch (ThreadAbortException)
            {
                throw;
            }
            catch (Exception e)
            {
                HandleError(e);
            }
        }

        public Action<Exception> HandleError;
    }
}

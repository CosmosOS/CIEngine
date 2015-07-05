using System;
using System.IO;
using Cosmos.CIEngine.Data;

namespace Cosmos.CIEngine
{
    partial class Engine
    {
        private void DumpItems()
        {
            var xOutput = @"c:\Data\CosmosCI\Events";

            if (Directory.Exists(xOutput))
            {
                Directory.Delete(xOutput, true);
            }
            Directory.CreateDirectory(xOutput);

            using (var xCtx = new DataContext())
            {
                foreach (var xItem in xCtx.Events)
                {
                    File.WriteAllText(Path.Combine(xOutput,
                                                   String.Format("{0}-{1}-{2}", xItem.EventId, xItem.Type, xItem.CreatedAt.ToString("yyyy-MM-dd-HH-mm-ss")) + ".json"),
                                      xItem.Payload);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.CIEngine.Data;

namespace Cosmos.CIEngine
{
    public partial class Engine
    {
        public string GithubOrganisation;
        public string GithubRepository;

        public void Start()
        {
            if (mIsStarted)
            {
                throw new InvalidOperationException("Cannot start the engine twice!");
            }

            #region check environment

            if (HandleError == null)
            {
                throw new Exception("No HandleError handler specified!");
            }
            if (String.IsNullOrWhiteSpace(GithubOrganisation))
            {
                throw new Exception("No GithubOrganisation specified!");
            }
            if (String.IsNullOrWhiteSpace(GithubRepository))
            {
                throw new Exception("No GithubRepository specified!");
            }

            using (var xCtx = new DataContext())
            {
                //
                xCtx.Configs.Count();
            }
            #endregion check environment

            //mIsStarted = true;
            EngineMain();
        }

        private bool mIsStarted = false;

        public void Stop()
        {
            if (!mIsStarted)
            {
                throw new Exception("Cannot stop engine!");
            }

            //
        }
    }
}

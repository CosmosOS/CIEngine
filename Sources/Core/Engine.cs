using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.CIEngine
{
    public partial class Engine
    {
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

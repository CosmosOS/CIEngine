using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.CIEngine.Data
{
    public class ConfigObj: BaseDataObject
    {
        public string Name
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }
    }
}

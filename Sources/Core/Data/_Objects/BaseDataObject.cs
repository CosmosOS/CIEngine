using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.CIEngine.Data
{
    public abstract class BaseDataObject
    {
        [Key]
        public Guid Identifier
        {
            get;
            set;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Cosmos.CIEngine
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

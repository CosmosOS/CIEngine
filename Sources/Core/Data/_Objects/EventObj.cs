using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.CIEngine.Data
{
    public class EventObj: BaseDataObject
    {
        [MaxLength(150)]
        public string Type
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }


        [MaxLength(150)]
        public string EventId
        {
            get;
            set;
        }

        public bool Processed
        {
            get;
            set;
        }

        [MaxLength(-1)]
        public string Actor
        {
            get;
            set;
        }

        [MaxLength(-1)]
        public string Organisation
        {
            get;
            set;
        }

        [MaxLength(-1)]
        public string Repository
        {
            get;
            set;
        }

        [MaxLength(-1)]
        public string Payload
        {
            get;
            set;
        }
    }
}

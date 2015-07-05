using System;
using System.ComponentModel.DataAnnotations;

namespace Cosmos.CIEngine.Data
{
    public class BuildObj: BaseDataObject
    {
        public Guid RelatedEventId
        {
            get;
            set;
        }

        public DateTime EnqueueTime
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

        [MaxLength(250)]
        public string SourceVersionSha1
        {
            get;
            set;
        }

        public BuildStateEnum State
        {
            get;
            set;
        }
    }
}

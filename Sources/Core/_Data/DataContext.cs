using System.Data.Entity;

namespace Cosmos.CIEngine
{
    public class DataContext: DbContext
    {
        public DataContext():base("name=Data")
        {
        }

        public DbSet<ConfigObj> Configs
        {
            get;
            set;
        }
    }
}

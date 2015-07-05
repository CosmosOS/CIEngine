using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Cosmos.CIEngine.Data
{
    public class DataContext: DbContext
    {
        public DataContext():base("name=Data")
        {
        }

        public string TryGetConfigStr(string name)
        {
            var xConfigEntry = Configs.SingleOrDefault(i=>i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (xConfigEntry != null)
            {
                return xConfigEntry.Value;
            }
            return null;
        }

        public void SetConfigStr(string name, string value)
        {
            var xConfigEntry = Configs.SingleOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (xConfigEntry != null)
            {
                xConfigEntry.Value = value;
                return;
            }
            xConfigEntry = new ConfigObj();
            xConfigEntry.Identifier = Guid.NewGuid();
            xConfigEntry.Name = name;
            xConfigEntry.Value = value;
            Configs.Add(xConfigEntry);
        }

        public DbSet<ConfigObj> Configs
        {
            get;
            set;
        }

        public DbSet<EventObj> Events
        {
            get;
            set;
        }
    }
}

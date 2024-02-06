using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Context.Configuration
{
    public class ConfigurationDbContext
    {
        private readonly string _connectionString;
        public ConfigurationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public string ConnectionString { get { return _connectionString; } }

    }
}

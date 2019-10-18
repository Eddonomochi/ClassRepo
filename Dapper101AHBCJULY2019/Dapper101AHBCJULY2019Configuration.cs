using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper101AHBCJULY2019
{
    public class Dapper101AHBCJULY2019Configuration
    {
        public Database Database { get; set; }
    }

    public class Database
    {
        public string ConnectionString { get; set; }
    }
}

using DataAccess.Databases;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SqlCrud

    {
        private static readonly IConfiguration config;
        private string _connectionString;
        private ISqlDataAccess db=new SqlDataAccess(config);
    }
}

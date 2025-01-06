using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DBMS_Northwind
{
    internal class ConnectDatabase
    {
        public static SqlConnection ConnectNorthwind()
        {
            string server = @".\SQLEXPRESS";
            string database = "northwind";
            string dsn = string.Format(@"Data Source={0};Initial Catalog={1};Integrated Security=True ;Encrypt=False", server, database);
            SqlConnection conn = new SqlConnection(dsn);
            conn.Open();
            return conn;
        }
    }
}

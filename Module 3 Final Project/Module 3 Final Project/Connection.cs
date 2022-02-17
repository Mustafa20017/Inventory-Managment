using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Module_3_Final_Project
{
    class Connection
    {
        public static SqlConnection connection;
        public static SqlConnection GetConnection()
        {
            if(connection == null)
            {
                connection = new SqlConnection();
                connection.ConnectionString = "Data Source = (local); Initial Catalog = Inventory Managment System; Integrated Security = SSPI";

            }
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}

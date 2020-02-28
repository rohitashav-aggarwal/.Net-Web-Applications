using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_CPRG214_Lab2
{
    public class TechSupportDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=TechSupport;Integrated Security=True";

            return new SqlConnection(connectionString);
        }
    }
}
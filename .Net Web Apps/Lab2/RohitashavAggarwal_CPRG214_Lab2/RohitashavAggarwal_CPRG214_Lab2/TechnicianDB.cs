using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_CPRG214_Lab2
{
    public class TechnicianDB
    {
        public static List<Technician> GetTechnicians()
        {
            // empty list to collect all the technician id and names
            List<Technician> technicians = new List<Technician>();
            Technician tech;

            using(SqlConnection connection = TechSupportDB.GetConnection())
            {
                // query to extract data from database
                string query = "SELECT TechID, Name FROM Technicians ORDER BY Name";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // reader to read data
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) // while there are results from query
                        {
                            // process each product and add to list
                            tech = new Technician();
                            tech.TechID = (int)reader["TechID"];
                            tech.Name = (string)reader["Name"];

                            technicians.Add(tech); // add data to the list
                        }
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return technicians; // return the list
        }// end of method
    }// end of class
}// end of namespace
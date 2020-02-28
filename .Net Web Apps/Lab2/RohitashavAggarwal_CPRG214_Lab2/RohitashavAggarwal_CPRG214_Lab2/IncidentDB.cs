using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Windows.Forms;

namespace RohitashavAggarwal_CPRG214_Lab2
{
    public class IncidentDB
    {
        public static List<Incident> GetIncidents(int TechnicianID)
        {
            // empty list to store the retrieved values
            List<Incident> incidents = new List<Incident>();
            

            using (SqlConnection connection = TechSupportDB.GetConnection())
            {
                // query to extract values from database
                string query = "SELECT * FROM Incidents WHERE TechID = @TechID ORDER BY DateOpened DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@TechID", TechnicianID);

                        connection.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        while (reader.Read()) // while there are results from query
                        {
                            // process each product and add to list
                            Incident inc = new Incident();
                            inc.IncidentID = (int)reader["IncidentID"];
                            inc.CustomerID = (int)reader["CustomerID"];
                            inc.ProductCode = (string)reader["ProductCode"];
                            inc.TechnicianID = (reader["TechID"] == DBNull.Value) ? null : (int?)reader["TechID"];
                            inc.DateOpen = (DateTime)reader["DateOpened"];
                            inc.DateClose = (reader["DateClosed"] == DBNull.Value) ? null : (DateTime?)reader["DateClosed"];
                            inc.Title = (string)reader["Title"];
                            inc.Decription = (string)reader["Description"];
                            
                            incidents.Add(inc);
                        }
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                    
                }
            }
            return incidents;
        }// end of method

        //Update method to update DateClosed and description of an incident
        public static void UpdateIncidents(Incident incident)
        {
            // establish the connection
            using (SqlConnection connection = TechSupportDB.GetConnection())
            {
                // query to update dateclose and description
                string query = "UPDATE incidents " +
                               "SET description = @desc, " +
                               "DateClosed = @dateclose " +
                               "WHERE IncidentID = @id";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        // add values
                        //description update edited value
                        if (incident.Decription == null) {
                            cmd.Parameters.AddWithValue("@desc", "Description unavailable");
                        }
                        else {
                            cmd.Parameters.AddWithValue("@desc", incident.Decription);
                        }
                        // dateclose update value
                        if (!incident.DateClose.HasValue) // if there is not value then add null value
                        {
                            cmd.Parameters.AddWithValue("@dateclose", DBNull.Value);
                        }
                        else if (incident.DateClose < incident.DateOpen) // if dateclose is less than dateopen then add null value
                        {
                            cmd.Parameters.AddWithValue("@dateclose", DBNull.Value);
                        }
                        else // only add the correct value
                        {
                            cmd.Parameters.AddWithValue("@dateclose", incident.DateClose);
                        }
                        cmd.Parameters.AddWithValue("@id", incident.IncidentID);

                        connection.Open();

                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex) // catch any exceptions from sql
                    {
                        throw ex;
                    }
                }// end of method
            }// end of class
        }// end of namespace

    }
}
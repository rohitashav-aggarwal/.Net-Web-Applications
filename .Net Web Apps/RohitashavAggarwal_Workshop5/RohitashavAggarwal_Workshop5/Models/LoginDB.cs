using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_Workshop5.Models
{
    public class LoginDB
    {
        public static string Login(string userName)
        {
            string storedPassword;

            Registration reg;

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "SELECT Password FROM customers WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@UserName", userName);
                        // run query
                        
                        storedPassword = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex) // unanticipated errors
                    {
                        throw ex;
                    }
                }
            }
            return storedPassword;
        }

        public static Registration GetCustomer(string userName)
        {
            string storedPassword;

            Registration reg = new Registration();

            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "Select CustFirstName, CustLastName, CustAddress ," +
                                "CustCity,CustProv,CustPostal,CustCountry,CustHomePhone," +
                                "CustBusPhone,CustEmail,UserName,Password from customers " +
                               "WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        decimal test = 0;
                        connection.Open();

                        cmd.Parameters.AddWithValue("@UserName", userName);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            reg.FirstName = reader[0].ToString();
                            reg.LastName = reader[1].ToString();
                            reg.Address = reader[2].ToString();
                            reg.City = reader[3].ToString();
                            reg.Province = reader[4].ToString();
                            reg.PostalCode = reader[5].ToString();
                            reg.Country = reader[6].ToString();
                            reg.HomePhone = reader[7].ToString();
                            if (!decimal.TryParse(reader[8].ToString(), out test))
                            {
                                reg.BusinessPhone = reader[8].ToString();
                            }
                            else
                            {
                                reg.BusinessPhone = null;
                            }

                            if (reader[9].ToString().Contains("@"))
                            {
                                reg.EmailID = reader[9].ToString();
                            }
                            else
                            {
                                reg.EmailID = null;
                            }
                            reg.UserName = reader[10].ToString();

                        }
                    }
                    catch (Exception ex) // unanticipated errors
                    {
                        throw ex;
                    }
                }
            }
            return reg;
        }
    }
}
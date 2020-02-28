using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace RohitashavAggarwal_Workshop5.Models
{
    public class RegistrationDB
    {
        public static void RegisterCustomer(Registration register)
        {
            using(SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string query = "INSERT INTO Customers " +
                               "(CustFirstName, CustLastName, CustAddress, CustCity, CustProv, " +
                               "CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, " +
                               "UserName, Password, ConfirmPassword) " +
                               "Values (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, " +
                               "@CustPostal, @CustCountry, @CustHomePhone, @CustBusPhone, @CustEmail, " +
                               "@UserName, @Password, @ConfirmPassword)";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustFirstName", register.FirstName);
                    cmd.Parameters.AddWithValue("@CustLastName", register.LastName);
                    cmd.Parameters.AddWithValue("@CustAddress", register.Address);
                    cmd.Parameters.AddWithValue("@CustCity", register.City);
                    cmd.Parameters.AddWithValue("@CustProv", register.Province);
                    cmd.Parameters.AddWithValue("@CustPostal", register.PostalCode);
                    cmd.Parameters.AddWithValue("@CustCountry", register.Country);
                    cmd.Parameters.AddWithValue("@CustHomePhone", register.HomePhone);
                    cmd.Parameters.AddWithValue("@CustBusPhone", register.BusinessPhone);
                    cmd.Parameters.AddWithValue("@CustEmail", register.EmailID);
                    cmd.Parameters.AddWithValue("@UserName", register.UserName);
                    cmd.Parameters.AddWithValue("@Password", register.Password);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", register.ConfirmPassword);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
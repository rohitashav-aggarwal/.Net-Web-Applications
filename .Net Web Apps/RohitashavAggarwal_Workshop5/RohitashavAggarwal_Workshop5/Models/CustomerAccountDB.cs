using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_Workshop5.Models
{
    public class CustomerAccountDB
    {

        public static void UpdateAccount(Registration regis, string user)
        {
            using(SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string query = "UPDATE customers " +
                               "SET CustFirstName = @FirstName, " +
                               "CustLastName = @LastName, " +
                               "CustAddress = @Address, " +
                               "CustCity = @city, " +
                               "CustProv = @Prov, " +
                               "CustPostal = @Postal, " +
                               "CustCountry = @Country, " +
                               "CustHomePhone = @HomePhone, " +
                               "CustBusPhone = @BusPhone, " +
                               "CustEmail = @Email, " +
                               "UserName = @UserName, " +
                               "Password = @Password, " +
                               "ConfirmPassword = @ConfirmPassword " +
                               "WHERE UserName = @User";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        cmd.Parameters.AddWithValue("@FirstName", regis.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", regis.LastName);
                        cmd.Parameters.AddWithValue("@Address", regis.Address);
                        cmd.Parameters.AddWithValue("@city", regis.City);
                        cmd.Parameters.AddWithValue("@Prov", regis.Province);
                        cmd.Parameters.AddWithValue("@Postal", regis.PostalCode);
                        cmd.Parameters.AddWithValue("@Country", regis.Country);
                        cmd.Parameters.AddWithValue("@HomePhone", regis.HomePhone);
                        cmd.Parameters.AddWithValue("@BusPhone", regis.BusinessPhone);
                        cmd.Parameters.AddWithValue("@Email", regis.EmailID);
                        cmd.Parameters.AddWithValue("@UserName", regis.UserName);
                        cmd.Parameters.AddWithValue("@Password", regis.Password);
                        cmd.Parameters.AddWithValue("@ConfirmPassword", regis.ConfirmPassword);
                        cmd.Parameters.AddWithValue("@User", user);

                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
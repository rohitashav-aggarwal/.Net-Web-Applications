using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RohitashavAggarwal_Workshop5.Models
{
    public class Encryption
    {
        public static string Encrypt(string Password)
        {
            string pass;

            pass = BCrypt.Net.BCrypt.HashPassword(Password);

            return pass;
        }

        public static bool Decrypt(string Password, string hash)
        {
            bool success;
            
            success = BCrypt.Net.BCrypt.Verify(Password, hash);

            return success;
        }
    }
}
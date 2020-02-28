using System;
using BCrypt.Net;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            //string encrypted = Encrypt(password);
            Console.WriteLine($"Password is: {password }");
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            Console.WriteLine($"Encrypted: {passwordHash}");
            Console.WriteLine();

            string password3 = Console.ReadLine();
            //string encrypted = Encrypt(password);
            Console.WriteLine($"Password is: {password3 }");
            string passwordHash3 = BCrypt.Net.BCrypt.HashPassword(password3);
            Console.WriteLine($"Encrypted: {passwordHash3}");
            Console.WriteLine();


            string password2 = Console.ReadLine();
            Console.WriteLine($"Password2 : {password2}");
            bool success = BCrypt.Net.BCrypt.Verify(password2, passwordHash);
            Console.WriteLine($"Success: {success}");

            Console.WriteLine("\n\nPress Any Key to Exit....");
            Console.ReadKey();
        }
        //public static string Encrypt(string password)
        //{
        //    var sha1Provider = new SHA1CryptoServiceProvider();
        //    var unicodeEncoding = new UnicodeEncoding();

        //    var hash = sha1Provider.ComputeHash(unicodeEncoding.GetBytes(password));

        //    return Encoding.UTF8.GetString(hash, 0, hash.Length);

        //}


        //public static string Encrypted(string password)
        //{
        //    Bcrypt
        //}
    }
   
}

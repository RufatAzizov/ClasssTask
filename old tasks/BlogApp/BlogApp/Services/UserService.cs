using BlogApp.Helpers;
using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Data;

namespace BlogApp.Services
{
    internal class UserService
    {
        int Register(User data)
        {
            //hash password
            //using SHA256 sha256 = SHA256.Create();    
            //string hashPassword = GetHash(sha256Hash, data.Password);
            string password = Console.ReadLine();

            // Generate a 128-bit salt using a sequence of
            // cryptographically strong random bytes.
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8); // divide by 8 to convert bits to bytes
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            string query = $"INSERT INTO Users VALUES (N'{data.Name}',N'{data.Surname}',N'{data.Surname}', {hashed} )";
            return SqlHelper.Exec(query);
        }
        void Login(string username, string password)
        {
            if DataTable.Rows.Count == 0) 
            { 

            }
        }

        //ICollection<User> void GetAllUsers() 
        //{
        //    Console.WriteLine("sample");
        //}
    }
}

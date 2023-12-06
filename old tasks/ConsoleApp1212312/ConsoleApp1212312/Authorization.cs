using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1212312
{
    public static class Authorization 
    {
        public static void Register(string name, string surname, string username, string password)
        {

        CheckUSer:
        CheckPass:
            if (username.Length > 4 && password.Length > 6)
            {
                User newUser = new User()
                {
                    Name = name,
                    Surname = surname,
                    Username = username,
                    Password = password
                };
            }
            
                else if (username.Length <= 4)
                {
            
                Console.WriteLine("\nUsername must be more than 4 characters! Try again:\n ");
                    username = Console.ReadLine();
                    goto CheckUSer;

                }
            else if (password.Length <= 6)
            {
            
                Console.WriteLine("Password must be more than 6 characters");
                password = Console.ReadLine();
                goto CheckPass;

            }







            static void Login(string Username, string Password)
                {

                }
                static string Logout()
                {
                    return null;
                }

            
        }

        private class users
        {
        }
    }

}

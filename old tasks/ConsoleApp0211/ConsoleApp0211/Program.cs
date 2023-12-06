using ConsoleApp0211.Models;
using System.Xml.Linq;

namespace ConsoleApp0211
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateUser();

            static User CreateUser()
            {
                Console.WriteLine("Enter your Name\n");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter yout age\n");
                byte Age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter your phone number\n");
                string Number = Console.ReadLine();
                Console.WriteLine("Create a password\n");
                string Password = Console.ReadLine();

                return new User(Name, Age, Number, Password);
            }

        }
    }
}
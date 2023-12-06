using System.Reflection.Metadata;
using Core.Models;

namespace ConsoleApp1212312
{
    public class Program
    {
        public static List<User> users = new List<User>();
        public static User LogedIn { get; set; }
        static void Main(string[] args)
        {
            int input;

            do
            {
                Console.WriteLine("Please choose an option\n");
                Console.WriteLine($"1 -> Login\n" + $"2 -> Register\n" + $"3 -> See all users\n" + $"0 -> To exit\n");
                if (int.TryParse(Console.ReadLine(), out input))
                    
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("\nYou chose Login.\n");
                            break;
                        case 2:
                            Console.WriteLine("\nYou chose Register.\n");
                            Console.WriteLine("\nWrite your username (must be more than 4 characters):\n");
                            string username = Console.ReadLine();
                            Console.WriteLine("\nCreate a password (must be more than 6 characters):\n");
                            string password = Console.ReadLine();
                            Console.WriteLine("\nWrite your Name:\n");
                            string name = Console.ReadLine();
                            Console.WriteLine("\nWrite your Surname:\n");
                            string surname = Console.ReadLine();
                            Authorization.Register(name, username, password, surname); 
                            
                            

                            break;
                    }


                        //case 3:
                        //    Console.WriteLine("\nYou chose See all users.\n");
                        //    break;
                        //default:
                        //    Console.WriteLine("\nInvalid option. Please choose a valid option.\n");
                        //    break;
                    
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number (1, 2, or 3).\n");
                } 
            } while (true);


        }



    }
}
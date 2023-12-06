using ClassInheritance.Models;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;

namespace ClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrontEndDeveloper developer1 = new FrontEndDeveloper
            {
                Name = "Fuad",
                Surname = "Khalilov",
                Age = 20,
                Experience = 2,
                Salary = 0,
                KnownLanguages = new[] { "JavaScript", "HTML", "CSS" },
                CodeLineCount = 2000
            };
            FrontEndDeveloper fe = new FrontEndDeveloper();
            fe.KnownLanguages = new[] { "Css" };
            fe.Name = "TestDev";
            fe.Surname = "TestDev";
            developer1.WriteCode();
            Console.WriteLine();
            fe.WriteCode();
            Console.WriteLine();

            Plane plane = new Plane
            {
                Brand = "Airbus",
                Model = "A319",
                MaxSpeed = 541,
                ProducedYear = 1994
            };

            Car car = new Car
            {
                Brand = "BMW",
                Model = "X5",
                MaxSpeed = 220,
                ProducedYear = 1999
            };

            Vehicle[] vehicles = new Vehicle[] {plane, car};

            Console.WriteLine(plane.GetMaxSpeed());

            Console.WriteLine(car.GetMaxSpeed());

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Model} was produced in {vehicle.ProducedYear}");
            }

            static int IndexOf (string word, char character)
            {
                int index = -1;
                for (int i = 0; i < word.Length; i++)
                {
                    
                    if (character == word[i])
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }

            

            //static int LastIndexOf(string word, char character)
            //{
            //    int index = -1;
            //    for (int i = 0; i < word.Length; i++)
            //    {

            //        if (character == word[i])
            //        {
            //            index = i;
            //        }
            //    }
            //    return index;
            //}

            static int LastIndexOf(string word, string value)
            {
                for (int i = word.Length - value.Length; i >= 0; i--)
                {
                    bool found = true;

                    for (int j = 0; j < value.Length; j++)
                    {
                        if (word[i + j] != value[j])
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                        return i;
                }
                return -1;
            }
            
            

            string word = "HelloHello";

            word.LastIndexOf(word);
            
            Console.WriteLine(IndexOf(word, 'l'));
            Console.WriteLine(LastIndexOf(word, "el"));
        }
    }
}
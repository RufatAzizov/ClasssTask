using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0311.Models
{
    public class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drives car");
        }

        public static bool operator <(Car vehicle1, Car vehicle2)
        {
            if (vehicle1.price < vehicle2.price)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Car vehicle1, Car vehicle2)
        {
            if (vehicle1.price > vehicle2.price)
            {
                return true;
            }
            return false;
        }
    }
}

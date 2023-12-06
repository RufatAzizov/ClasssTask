using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0311.Models
{
    public class Bus : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drives bus");
        }
    }
}

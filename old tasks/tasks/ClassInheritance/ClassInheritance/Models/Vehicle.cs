using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Models
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int ProducedYear;
        public int MaxSpeed;

        public string GetMaxSpeed()
        {
            return $"Vehicle {Brand} {Model} can run at speed {MaxSpeed}";
        }
    }
}

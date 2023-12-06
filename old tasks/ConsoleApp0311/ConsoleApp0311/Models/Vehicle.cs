using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0311.Models
{
    public abstract class Vehicle
    {
        public double price { get; set; }

        public Vehicle() 
        { 
            
        }

        public abstract void Drive();

        
    }
}

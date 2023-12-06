using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FigureTask
{
    internal class Rectangle : Figure
    {
        private double _a; private double _b;

        public double a
        {
            get => a; set { if (a > 0) { a = value; } else Console.WriteLine("Side must be positive number"); } 
        }
        public double b
        {
            get => b; set { if (b > 0) { b = value; } else Console.WriteLine("Side must be positive number"); }
        }



        public override void CalcArea()
        {
            Console.WriteLine($"Area is {a*b}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FigureTask
{
    internal class Square : Figure
    {
        private double _side; 
        public double side 
        {  
            get => side; 
            set { if (side>0) side = value; else Console.WriteLine("Side must be positive number"); }
            
        }
       

       
        


        public override void CalcArea()
        {
            Console.WriteLine($"Area is {side*side}");

        }
    }
}

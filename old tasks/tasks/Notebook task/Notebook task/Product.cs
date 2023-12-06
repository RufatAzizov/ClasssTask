using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook_task
{
    public class Product
    {
        uint _count;
        decimal _price;

        public Product(uint count, double price) {

            count = count;
            price = price;
        }

        public uint count {  get; set; }
        public decimal price {  get => _price; set { if (value > 0) { _price = value; } else Console.WriteLine("price must be positive number"); } } //check for _price maybe wrong 

    }
}

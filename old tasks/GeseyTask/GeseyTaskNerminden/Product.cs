using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeseyTaskNerminden
{
    public abstract class Product 
    {
        string _title { get; set; }
        double _price { get; set; }
        uint _count { get; set; }
        protected decimal _totalIncome { get; set; }

        public Product(string title, double price, uint count)
        {
            _title = title;
            _price = price; 
            _count = count;
        }

        //static uint _id = 1;
        //public Product(uint id)
        //{
        //    _id = id;
        //    id += id;

        //}


        public abstract void Sell();

        public abstract void ShowInfo();
        

    }
}

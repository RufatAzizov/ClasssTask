using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook_task
{
    public class Notebook : Product
    {
        string _brand;
        uint _ram;
        //string _model;
        //uint _storage;

        public Notebook(uint count, double price, string model) : base(count, price)
        {
            model = model;
        }

        public string brand 
        { 
            get => _brand; 
            set 
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _brand = value;
                }
                else Console.WriteLine("Wrong notebook name");
            } 
        }
        public string model { get; set; }
        public uint ram { get => _ram; set { if (value<=128) { _ram = value; } else Console.WriteLine("RAM must be less than 129"); } } // maybe wrong tho
        public uint storage { get; set; }
    }
}

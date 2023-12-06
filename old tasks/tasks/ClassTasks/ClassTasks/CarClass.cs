using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    public class Car
    {
        public string Brand;
        public string Model;
        public string Color;
        public int SeatNumber;

        public string GetCarInfo()
        {
            return $"Brand: {Brand}, Model: {Model}";
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
    }
}

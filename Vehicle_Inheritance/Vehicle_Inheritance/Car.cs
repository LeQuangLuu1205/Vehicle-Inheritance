using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    class Car : Vehicle
    {
        public Car(string brand, int year, decimal price)
        {
            Brand = brand;
            Year = year;
            Price = price;
        }
    }
}

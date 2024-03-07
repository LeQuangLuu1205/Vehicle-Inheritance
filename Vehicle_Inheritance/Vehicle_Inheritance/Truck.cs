using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    class Truck : Vehicle
    {
        public string Company { get; set; }

        public Truck(string brand, int year, decimal price, string company)
        {
            Brand = brand;
            Year = year;
            Price = price;
            Company = company;
        }
    }
}

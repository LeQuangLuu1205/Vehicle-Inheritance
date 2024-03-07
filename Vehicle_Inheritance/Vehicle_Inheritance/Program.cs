using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
        {
            new Car("Toyota", 1995, 150000),
            new Car("Honda", 2000, 200000),
            new Car("Ford", 1998, 180000),
            new Car("Toyota", 1992, 220000),
            new Car("Honda", 2005, 300000),
            new Car("Ford", 1996, 120000)
        };

            // Hiển thị các xe có giá trong khoảng 100.000 đến 250.000 và năm sản xuất > 1990
            var filteredCars = cars.Where(car => car.Price >= 100000 && car.Price <= 250000 && car.Year > 1990);

            // Gom các xe theo hãng sản xuất và tính tổng giá trị theo nhóm
            var carBrands = filteredCars.GroupBy(car => car.Brand)
                                        .ToDictionary(group => group.Key, group => group.Sum(car => car.Price));

            Console.WriteLine("Total prices of cars by brand:");
            foreach (var brand in carBrands)
            {
                Console.WriteLine($"{brand.Key}: {brand.Value}");
            }

            // Tạo danh sách các Truck
            List<Truck> trucks = new List<Truck>
        {
            new Truck("Volvo", 2015, 350000, "Volvo Group"),
            new Truck("Ford", 2010, 280000, "Ford Motor Company"),
            new Truck("Scania", 2020, 400000, "Scania AB"),
            new Truck("Mercedes-Benz", 2018, 380000, "Daimler AG")
        };

            // Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            var sortedTrucks = trucks.OrderByDescending(truck => truck.Year);
            Console.WriteLine("\nTrucks sorted by year of manufacture:");
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"Year: {truck.Year}, Brand: {truck.Brand}");
            }

            // Hiển thị tên cty chủ quản của Truck
            Console.WriteLine("\nCompany owners of trucks:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"Brand: {truck.Brand}, Company: {truck.Company}");
            }
            Console.ReadLine();
        }
    }
}

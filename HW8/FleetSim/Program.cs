using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;

namespace FleetSim
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rdmMiles = new Random();
            string carGuid = Guid.NewGuid().ToString();

            var cars = new List<Car>
            {
                new Car() { year = 2016, make = "Ford", model = "Escape", carColor=CarColor.Red.ToString(),
                            vin = carGuid, mileage = 0},

                new Car() { year = 2015, make = "Ford", model = "Explorer", carColor=CarColor.White.ToString(),
                            vin = carGuid, mileage = 0},

                new Car() { year = 2017, make = "Ford", model = "Mustang", carColor=CarColor.Blue.ToString(),
                            vin = carGuid, mileage = 0},

                new Car() { year = 2014, make = "Ford", model = "Focus", carColor=CarColor.Red.ToString(),
                            vin = carGuid, mileage = 0},


                new Car() { year = 2018, make = "Ford", model = "F150", carColor=CarColor.Blue.ToString(),
                            vin = carGuid, mileage = 0},
            };

            try
            {
                int listIndex = 0;
                do
                {
                    for (int counter = 1; counter <= 10; counter++)
                    {
                        cars[listIndex].mileage += rdmMiles.Next(5000, 15000);
                        System.Threading.Thread.Sleep(20);

                        cars[listIndex].TuneUp();

                        Console.WriteLine($"{cars[listIndex].year.ToString()} " +
                            $"{cars[listIndex].make} {cars[listIndex].model} " +
                            $"{cars[listIndex].carColor} Vin: {cars[listIndex].vin} " +
                            $"Mileage: {cars[listIndex].mileage} ");
                    }

                    listIndex++;
                    Console.WriteLine("\n");
                } while (listIndex <= cars.Count - 1);

                Console.ReadLine();
            }
            catch(Exception Ex)
            {
                Console.WriteLine("An error has occurred. Please contact the system administrator.");
            }

        }
    }
}

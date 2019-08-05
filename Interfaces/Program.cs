using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var driver = new Driver("James", false);

                var cars = new List<CarBase>
            {
                new Truck("Ford", "F150", "Black", 20_000, true, 6, driver),
                new Sedan("Honda", "Civic", "White", 80_000, driver)
            };

                foreach (var car in cars)
                {
                    car.Honk();
                    Console.WriteLine(car.Driver.Name);
                }

                // interface example, "L" in solid 

                IGPS gps = new Truck("Ford", "F150", "Black", 20_000, true, 6, driver);

                gps.Navigate();
            }
            catch (Exception e)
            {
                ILogger logger = new EmailLogger();
                logger.Log(e.StackTrace);
                throw;
            }
        }
    }
}

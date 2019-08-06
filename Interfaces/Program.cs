using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            KitchenTime();
            try
            {
                var driver = new Driver("James", false);

                var cars = new List<CarBase>
            {
                // new Truck("Ford", "F150", "Black", 20_000, true, 6, driver),
            };

                foreach (var car in cars)
                {
                    car.Honk();
                    Console.WriteLine(car.Driver.Name);
                }

                // interface example, "L" in solid 

                // IGPS gps = new Truck("Ford", "F150", "Black", 20_000, true, 6, driver);

               // gps.Navigate();
            }
            catch (Exception e)
            {
                ILogger logger = new SplunkLogger();

                logger.Log(e.StackTrace);
                throw;
            }
        }

        private static void InterfaceExamples()
        {
            ITurbo turbo = new Sedan(
                "honda",
                "civic",
                "white",
                42000,
                new Driver("James", true),
                new Tire[] 
                {
                    new Tire(),
                    new Tire(),
                    new Tire(),
                    new Tire()
                });

            turbo.GoFaster();

            (turbo as Sedan).GetMileage();
        }

        public static void KitchenTime()
        {
            var kitchen = new Kitchen();

            kitchen.LoadDishWasher(new List<string>()
            {
                "bowl",
                "spoon",
                "fork",
                "knife",
                "plate"
            });

            kitchen.SetOven(350, 30);
        }
    }
}

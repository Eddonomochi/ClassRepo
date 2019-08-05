using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public abstract class CarBase
    {
        public CarBase(string make, string model, string color, int mileage, Driver driver)
        {
            Make = make;
            Model = model;
            Color = color;
            Mileage = mileage;
            Driver = driver;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public Driver Driver { get; set; }

        public abstract void Honk();
        public abstract void Brake();
    }
}

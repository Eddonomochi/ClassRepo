using System;
using System.Collections.Generic;
using System.Text;

namespace OOPYouKknowMe
{
    public class Shoe
    {
        public int Height { get; set; }
        public string Color { get; set; }
        public bool HasMetallics { get; set; }

        public Shoe(int height, string color, bool hasMetallics)
        {
            Height = height;
            Color = color;
            HasMetallics = hasMetallics;

            ShoeConstructorMessage();
        }

        public Shoe()
        {
            ShoeConstructorMessage();
        }

        private void ShoeConstructorMessage()
        {
            Console.WriteLine("new shoe created!");
        }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }

        public void MakesNoise()
        {

        }
    }
}

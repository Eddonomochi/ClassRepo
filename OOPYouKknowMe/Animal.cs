using System;
using System.Collections.Generic;
using System.Text;

namespace OOPYouKknowMe
{
    public class Animal
    {
        public string Gender { get; set; }
        public int Legs { get; set; }
        public double Weight { get; set; }
        public bool IsAlive { get; set; }

        public Animal(string gender, int legs, double weight, bool isAlive)
        {
            Gender = gender;
            Legs = legs;
            Weight = weight;
            IsAlive = isAlive;

            UseRestroom();

        }

        public Animal()
        {

        }

        public Animal(int legs, bool isAlive)
        {

        }

        public void Eat()
        {
            Console.WriteLine("I am eating");

            UseRestroom();

            Console.WriteLine("nothing to see here");
        }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }

        private void UseRestroom()
        {
            Console.WriteLine(".... just doing my business...");
        }
    }
}

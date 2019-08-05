using System;
using System.Collections.Generic;
using System.Text;

namespace PolyInher
{
    public class Animal
    {
        public Animal(int weight, string gender)
        {
            this.Weight = weight;
            this.Gender = gender;
        }

        public Animal()
        {

        }

        public int Weight { get; set; }
        public bool IsAlive { get; set; }
        public string Gender { get; set; }
        public int Legs { get; set; }

        public virtual string MakeNoise()
        {
            return "animal noise, beep boop";
        }
        
        public virtual string MakeNoise(string noise)
        {
            return $"I am making this cool noise, {noise} ,I am an animal";
        }

        protected void SmashWatermelon()
        {
            var watermelon = GetWatermelon();
            Console.WriteLine($"smashing {watermelon}");
        }

        private string GetWatermelon()
        {
            return "new watermalon";
        }
    }
}

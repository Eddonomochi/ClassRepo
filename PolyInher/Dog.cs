using System;
using System.Collections.Generic;
using System.Text;

namespace PolyInher
{
       //  Dog     Inherits from        Animal
    public class Dog : Animal
    {
        private bool _isNootered;

        private const string NAME = "Fido";

        public Dog(int dogWeight, string dogGender, bool isNootered)
            : base(dogWeight, dogGender)
        {
            this._isNootered = isNootered;
        }

        public bool IsAGoodBoy { get; set; }
        public string Owner { get; set; }

        public static void Walk()
        {
            Console.WriteLine("Hey! I'm walking here!");
        } 

        public override string MakeNoise()
        {
            base.MakeNoise();

            Walk();

            Console.WriteLine(IsAGoodBoy);
            this.SmashWatermelon();

            return "bark bark!";
        }

        public override string MakeNoise(string noise)
        {
            return $"bark bark {noise} bark bark";
        }
    }
}

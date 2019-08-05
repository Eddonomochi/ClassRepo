 using System;
using System.Collections.Generic;

namespace PolyInher
{
    class Program
    {
        static void Main(string[] args)
        {

            var employees = new List<string>();

            employees.Add("James");


            var employee = new Employee("Rob", 120000);

            var id = employee.GetEmployeeID();

            employee.Name = "James";

            Console.WriteLine(employee.Name);

            Console.WriteLine(employee.GetEmployeeID());

            // Inheritence? I can't spell :(

            var animal = new Animal(12, "male");

            Console.WriteLine(animal.MakeNoise());

            var dog = new Dog(25, "female", false);
            dog.Gender = "boy";
            dog.Weight = 15;
            dog.IsAlive = true;
            dog.IsAGoodBoy = true;
            dog.Owner = "Vlad";


            Dog.Walk();


            string newOwner = dog.Owner;

            Console.WriteLine(dog.Owner);
            Console.WriteLine(dog.MakeNoise());
            


            var poodle = new Poodle(5, "male", true);

            poodle.MakeNoise();
            poodle.Gender = "Female";
            poodle.IsBourgeuis = true;
            Console.WriteLine(poodle.MakeNoise());


            // Polly had a cracker morphism

            var animals = new List<Animal>();


            animals.Add(new Dog(2, "male", true));
            animals.Add(new Whale());
            animals.Add(new Animal());

            foreach (var animalBoy in animals)
            {
                Console.WriteLine(animalBoy.MakeNoise());
            }

            Animal animalWink = new Poodle(2, "male", true);


            var allTheThings = new List<object>();
            allTheThings.Add(true);
            allTheThings.Add(new Animal());
            allTheThings.Add(23.5f);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPYouKknowMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalOne = new Animal("Female", 4, 13.38, true);


            var animalTwo = new Animal("Male", 4, 300.6, false);





            Console.WriteLine(animalOne.Gender);
            Console.WriteLine(animalTwo.Weight);


            // 4.2 OMG shoes!

            var shoe = new Shoe(3, "red", false);

            var shoes = new List<Shoe>();
            shoes.Add(new Shoe(2, "green", false));
            shoes.Add(new Shoe(12, "black", true));
            shoes.Add(new Shoe(6, "green", false));
            shoes.Add(new Shoe(1, "tan", false));
            shoes.Add(shoe);


            // 5.2 ya fired! Employee editoin.

            var employee = new Employee("Zach");

            var employeeTwo = new Employee();

            employee.Name = "Rob";
            var name = employee.Name;

            employee.HourlyRate = 25;
            employee.HoursWorked = 40;

            Console.WriteLine(13.2d);
            Console.WriteLine("sup dude");

            Console.WriteLine(employee.WeeklyIncome);
            Console.WriteLine(employee.Name);

            // 66.6 ... oh no....   1.2 Toys
            var toy = new Toy();
            toy.SetShape("a");
            Console.WriteLine(toy.GetShape());

            toy.SetShape("triangle");
            Console.WriteLine(toy.GetShape());
        }
    }
}

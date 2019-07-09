using System;

namespace AHBCJulyL1
{

    class Program
    {
        static void Main(string[] args)
        {

            // 1.1 console.writeline
            Console.WriteLine("Hey, please you enter your name?!");

            
            //TODO:  hey, we may change this variable name at some point LOL.
            //lol
            
            string userName = Console.ReadLine();

            Console.WriteLine($"hey {userName} how are you doing!");
            Console.ReadLine();

            // 1.2: variables
            string exampleString;

            exampleString = "I am a string";

            string otherExampleString = "I am not alone";

            exampleString = "I am a new string";

            string otherUserName;

            Console.WriteLine(exampleString);

            // 1.3 data types 

            // numbers
            long largeNumber;
            float num1;
            int num2;
            decimal num3;
            double num4;


            // other
            char letter = 's';
            bool isTrue = true;
            bool isFalse = false;


            // 1.4 Maths and stuff...

            int numOne = 15;
            int numTwo = 13;

            int numResult = numOne + numTwo;
            int otherNumResult = numResult * (numOne + numTwo);

            Console.WriteLine(otherNumResult);

            Console.ReadLine();

            numOne = numOne + 2;

            numOne += 2;
            numOne += 1;
            numOne++;
            numOne--;

            int modResult = numOne % numTwo;

            Console.WriteLine($"num one: {numOne}");
            Console.WriteLine($"num Two: {numTwo}");

            Console.WriteLine($"mod result: {modResult}");

            modResult %= 5;


            Console.ReadLine();

            // 1.5 Casting

            int smallNumber = 500;
            double newNumber = smallNumber;

            // You cannot store a string into a double... sorry dude.
            // newNumber = "hello";

            // Boolean expression 1.6

            int age = 30;

            bool isOld = 30 > 18;

            Console.WriteLine($"is James old: {isOld}");
            Console.ReadLine();
        }
    }
}

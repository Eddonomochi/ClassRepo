using System;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool errorCheck = true;
            //int inputNumber = 0;
            //do
            //{
            //    Console.WriteLine("hey user, I know this is an odd request, but can you just give a number of sorts?");

            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out inputNumber))
            //    {
            //        errorCheck = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("well, that wasn't a number, this is akward, but could you try again maybe?");
            //    }

            //    Console.Clear();
            //    errorCheck = false;
            //} while (errorCheck);

            //Console.WriteLine($"ah, so you are {inputNumber} year old lol.");






            // 1. take in the user input
            // 2.  validate the user input 
            //   if true 
            //       3. continue with program
            //   if false 
            //       3. repeat step 1


            //bool isResult = false;
            //bool shouldRepeatQuestion = true;
            //do
            //{
            //    Console.WriteLine("Do you want to go to the party? [true/false]");
            //    string userInput = Console.ReadLine();

            //    if (bool.TryParse(userInput, out isResult))
            //    {
            //        shouldRepeatQuestion = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("I am a robot, I only accept [true] OR [false] beep boop!");
            //    }
            //    Console.Clear();
            //}
            //while (shouldRepeatQuestion);

            //if (isResult)
            //{
            //    Console.WriteLine("BEEP BOOP, I LOVE YOU");
            //} 
            //else
            //{
            //    Console.WriteLine("thats cool man.");
            //}

            bool isInvalidInput = true;
            int age = 0;
            while (isInvalidInput)
            {
                Console.WriteLine("how old are you?");

                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out age))
                {
                    isInvalidInput = false;
                }
                else
                {
                    Console.WriteLine("do not play tricks on me, give me age!");
                }
            }


            if (age >= 21)
            {
                Console.WriteLine("you can buy booze");
            } 
            else
            {
                Console.WriteLine("get the fuck outta here.");
            }

            Console.WriteLine("thank you for being a friend");
        }
    }
}

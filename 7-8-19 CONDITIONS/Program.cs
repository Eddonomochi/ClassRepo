using System;

namespace _7_8_19_CONDITIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 if statements

           // Console.WriteLine("how old are you user");
            // int age = int.Parse(Console.ReadLine());

            //if (age > 30)
            //{
            //    Console.WriteLine($"wow, you are old... {age}, I'm sorry");
            //}
            //else
            //{
            //    Console.WriteLine("well, at least you still have your youth...");
            //}


            bool isAwesome = true;

            if (isAwesome)
            {

            }

            //if (age > 0)
            //{
            //    // run code inside of this block
            //}

            //if (age >= 31)
            //{
            //    Console.WriteLine($"wow, you are old... {age}, I'm sorry");
            //}
            //else if (age >= 21)
            //{
            //    Console.WriteLine("you can legally drink");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("You can vote");
            //}




            // 1.2 relational operators

            bool isExample = true;
            double length = 33.2;

            if (length == length)
            {
                Console.WriteLine("we are the same length!");
            }

            if (length != 15.2)
            {
                Console.WriteLine($"true, 15.2 is not the same number as {length}");
            }

            if (length > 15.2)
            {
                Console.WriteLine($"It's true, 15.2 is shorter then {length}");
            }

            if (length < 50)
            {
                Console.WriteLine($"It's true, 50 is longer then {length}");
            }

            if (length >= 15.2)
            {
                Console.WriteLine($"It's true, 15.2 is shorter then {length}");
            }

            if (length <= 50)
            {
                Console.WriteLine($"It's true, 50 is longer then {length}");
            }

            // 1.3 logical Operators 


            int lengthTwo = 4;

            if (lengthTwo < 5 && lengthTwo > 2)
            {
                Console.WriteLine($"{lengthTwo} falls between 5 and 2");
            }

            if (lengthTwo < 1 || lengthTwo > 3)
            {
                Console.WriteLine($"{lengthTwo} is either less then 1 OR greater than 3");
            }

            if (!(lengthTwo < 5|| lengthTwo > 2))
            {
                Console.WriteLine("reddit.com");
            }

            bool isExampleTwo = true;

            if (lengthTwo < 5 
                && isAwesome
                && isExampleTwo
                && true)
            {
                Console.WriteLine("lots of conditions!");
            }


            // 1.4 switch case
            int swtichNumber = 5;

            switch (swtichNumber)
            {
                case 1:
                case 2:
                    Console.WriteLine("I'm a 2!");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("I'm a 3!");
                    break;
                case 5:
                    Console.WriteLine("I'm a 5!");
                    break;
                default:
                    Console.WriteLine("I don't know you as a person...");
                    break;
            }


            // 1.5 WHILE LOOPS

            int count = 11;
            while (count < 10)  // step 1, check condition
            {
                Console.WriteLine($"Current value: {count}");  // step 2, run code
                count++;
            }  // step 3: repeat step 1


            // 1.6 DO WHILE LOOP

            int counterTwo = 0;

            do
            {
                Console.WriteLine("I'm only running once!");
                counterTwo++;
            } while (counterTwo == 0);


            // 1.7 FOR LOOPS

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            string input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i += 2)
            //{
            //    int j = 5;
            //}







            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 'a' || input[i] == 'u')
            //    {
            //        Console.WriteLine($"you're input is {input[i]}, at index: {i}");
            //    }
            //}



            // 1.7? foreach

            foreach (char letter in input)
            {
                Console.WriteLine(letter);
            }








            int countThree = 0;
            foreach (char letter in input)
            {
                if ( countThree < 3  
                    && (letter == 'p' || letter == 't'))
                {
                    Console.WriteLine("we did it reddit!");
                    countThree++;
                }
            }



            
            Console.ReadLine();
        }
    }
}

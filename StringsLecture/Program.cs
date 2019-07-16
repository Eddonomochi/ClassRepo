using System;
using System.Text;

namespace StringsLecture
{
    public class Program
    {
        public static string CapitalizeFirstLetter(string word)
        {
            string firstLetter = word[0].ToString().ToUpper();

            string restOfWord = word.Substring(1);

            string newWord = $"{firstLetter}{restOfWord}";
            return newWord;
        }

        public static int AddNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }
        

        static void Main(string[] args)
        {
            string name = "James Jackson";
                                // 0   1     2    3    4
            char[] helloArray = { 'H', 'e', 'l', 'l', 'o' };

            string nameTwo = new string("James Jackson");

            string nameThree = new string('a', 5);
            string helloString = new string(helloArray);

            string smashedGreeting = $"{helloString}I'm{name}";

            string greeting = helloString + " I'm " + name;
            string greetingTwo = $"{helloString} I'm {name}";
            string greetingThree = string.Concat(greeting, " I'm ", name);

            Console.WriteLine(smashedGreeting);
            Console.WriteLine(nameThree);
            Console.WriteLine(helloString);

            if(name.Equals(nameTwo, StringComparison.OrdinalIgnoreCase))
            {

            }

            int indexOfJames = greetingThree.IndexOf("Jimmy", StringComparison.OrdinalIgnoreCase);

            //if (indexOfJames != -1)
            //{
            //    Console.WriteLine($"Jimmy appears at index number: {indexOfJames}");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, but you were not chosen, tough break bruh.");
            //}

            //if (greetingThree.EndsWith("Jimmy"))
            //{
            //    Console.WriteLine("Hey Jimmy lol");
            //} 
            //else
            //{
            //    Console.WriteLine("No JImmy lol");
            //}


            string sentence = "I'm feeling really good today";

            string badSentence = sentence.Replace("good", "bad");

            string[] words = badSentence.Split(' ');

            char[] letters = badSentence.ToCharArray();

            Console.WriteLine(badSentence);

            Console.WriteLine($"amount of words in this sentence: {words.Length}");


            string[] splitSentence = sentence.Split('g');

            //foreach (var letter in letters)
            //{
            //    Console.WriteLine();
            //}

            //foreach (var word in splitSentence)
            //{
            //    Console.Write(word);
            //}

            //Console.WriteLine(sentence);

            //const string newConst = "new";

            //string newWord = "I am a new word";
            //int newIndex = newWord.IndexOf(newConst);
            //string subNewWord = newWord.Substring(newIndex, newConst.Length);
            //Console.WriteLine(subNewWord);

            //Console.ReadLine();


            // 1.6 StringBuilder

            StringBuilder builder = new StringBuilder();

            StringBuilder builder2 = builder;

            builder.Append("Hello");
            builder.Append(" I'm");
            builder.Append(" James");
            builder.Append(".");

            builder.Replace("Hello", "hi");

            string result = builder.ToString();

            Console.WriteLine(result);

            // 1.7 to upper to lower


            //string upperCaseString = result.ToUpper();

            //string lowerCaseString = result.ToLower();

            //string upperCaseFirstLetter = result[0].ToString().ToUpper();

            //string resultWithoutFirstChar = result.Substring(1);
            //string firstLetterUpperResult = $"{upperCaseFirstLetter}{resultWithoutFirstChar}";

            // Console.WriteLine(firstLetterUpperResult);


            // 1.13 example

            string notAPersonJames = "sup dude; you are james";

                                                    // 's'   <-   "s"   <-   "S"
            string upperLetterResult = notAPersonJames[0].ToString().ToUpper();

            // "sup dude; you are james" <-index 1-- "up dude; you are james"
            string subNotAPersonJames = notAPersonJames.Substring(1);

                                        // "Sup dude; you are james"
            string jamesIsAPerson = $"{upperLetterResult}{subNotAPersonJames}";

            // "Sup dude; you are james" <-  "Sup dude, you are james"
            string JamesHasAComma = jamesIsAPerson.Replace(';', ',');


            // 2.18 string function example

            string taName = "rob";
            string victoria = "victoria";
            string nicholas = "nicholas";




            //             "rob" <--------    "Rob"
            string properRob = CapitalizeFirstLetter(taName);
            string properVictoria = CapitalizeFirstLetter(victoria);
            string properNicholas = CapitalizeFirstLetter(nicholas);



            int five = 5;
            int six = 6;

            int numResultOne = AddNumbers(five, six);
            int NumResultResult = AddNumbers(numResultOne, numResultOne);

            Console.WriteLine(AddNumbers(NumResultResult, NumResultResult));



            Console.WriteLine(properRob);

            Console.ReadLine();
        }

        
    }
}

using System;
using System.Text;
using System.Text.RegularExpressions;

namespace FunctionsYay
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.0 the exersize

            //string word = "      He    Dude    I'm a word   ";

            //string[] newWord = word.Trim().Split(' ');

            //string result = CaptalizeOddLowerCaseEvenLetters("hey");

            //int num = 2;

            //string emptyResult = CaptalizeOddLowerCaseEvenLetters(ref num);
            //string otherEmptyResult = CaptalizeOddLowerCaseEvenLetters(num);

            GetFactorial(5);

            int numResult = AddNumbers(5);


            // 5.2 Regex

            string name = "James B Jackson";

            if(TryValidateName(name, out string outName))
            {
                Console.WriteLine("You are a person");
            }

            if (TryValidateName("23", out string outNameTwo))
            {
                Console.WriteLine("You are a person");
            }
        }

        static string CaptalizeOddLowerCaseEvenLetters(string anyWord)
        {
            // StringBuilder builder = new StringBuilder();

            string moddedWordSon = "";
            for (int i = 0; i < anyWord.Length;  i++)
            {
                if (anyWord[i] == ' ') continue;

                if (i % 2 != 0)
                {
                    moddedWordSon += anyWord[i].ToString().ToLower();
                }
                else
                {
                    moddedWordSon += anyWord[i].ToString().ToUpper();
                }
            }

            return moddedWordSon;
        }

        static string CaptalizeOddLowerCaseEvenLetters(string[] anyWords)
        {
            return "";
        }

        static string CaptalizeOddLowerCaseEvenLetters(char[] anyWords)
        {
            return "";
        }


        static string CaptalizeOddLowerCaseEvenLetters(ref int numberForReasons)
        {
            numberForReasons++;

            return "";
        }

        static string CaptalizeOddLowerCaseEvenLetters(int numberForReasons)
        {
            numberForReasons++;

            return "";
        }


        public static int AddNumbers(int number)
        {
            if (number > 10)
            {
                return number;
            }


            return AddNumbers(number + 1);
        }

        public static double GetFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }


            return number * GetFactorial(number - 1);
        }

        public static bool TryValidateName(string inputName, out string outputName)
        {
            string pattern = @"^(\w+\s\w+[\S])|(\w+\s\w\s\w+[\S])$";

            Regex regex = new Regex(pattern);

            string name = "James B Jackson";

            if (regex.IsMatch(inputName))
            {
                outputName = name;
                return true;
            }
            else
            {
                outputName = string.Empty;
                return false;
            }
        } 
    }
}

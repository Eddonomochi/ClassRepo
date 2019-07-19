using System;
using System.Text.RegularExpressions;

namespace _7_18_VALIDATION_HANDLING
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunApp();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("womp womp, we failed");
            }

        }

        public static void RunApp()
        {


            Console.WriteLine("Hey, give that email doh");

            string userInput = Console.ReadLine();


            bool canDrink = 5 > 21;

            string outputMessage = IsValidZipCode(userInput)
                ? "I kind of have an idea where you live"
                : "Invalid zip code";
        }


        public static bool IsValidZipCode(string zipCodeInQuestion)
        {
            Regex pattern = new Regex(@"^[0-9]{5}([ -][0-9]{4})?$");

            return pattern.IsMatch(zipCodeInQuestion);
        }
    }
}

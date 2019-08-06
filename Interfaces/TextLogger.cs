using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class TextLogger : ILogger
    {
        private int _phoneNumber = 1112223333;

        public void Log(object error)
        {
            Console.WriteLine($"Now texting {error} to {_phoneNumber}");
        }
    }
}

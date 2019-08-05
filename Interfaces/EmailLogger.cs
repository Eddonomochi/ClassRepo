using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class EmailLogger : ILogger
    {
        private string _emailAddress = "awesomeEmail@Email.com";

        public void Log(object error)
        {
            Console.WriteLine($"logging to {_emailAddress}, {error}");
        }
    }
}

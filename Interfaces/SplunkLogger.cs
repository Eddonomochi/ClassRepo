using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SplunkLogger : ILogger
    {
        public void Log(object error)
        {
            Console.WriteLine($"logging splunk error: {error} to our splunk server");
        }
    }
}

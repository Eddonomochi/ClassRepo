using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupExample.Models
{
    public class HelloViewModel
    {
        public HelloViewModel(string helloMessage, IEnumerable<string> otherMessages)
        {
            this.HelloMessage = helloMessage;
            this.OtherMessages = otherMessages;
        }

        public string HelloMessage { get; set; }
        public IEnumerable<string> OtherMessages { get; set; }
    }
}

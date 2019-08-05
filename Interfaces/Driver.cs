using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Driver
    {
        public Driver(string name, bool ownsTitle)
        {
            Name = name;
            OwnsTitle = ownsTitle;
        }
        
        public string Name { get; set; }
        public bool OwnsTitle { get; set; }

        public Driver GetCurrentDriver()
        {
            return this;
        }
    }
}

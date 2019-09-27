using StartupExample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupExample
{
    public class LGFridge : IFridge
    {

        public LGFridge(HomeController controller)
        {

        }

        public bool ChangeTempature(int degree)
        {
            Console.WriteLine($"oo, {degree}F? thats something...");
            return true;
        }
    }
}

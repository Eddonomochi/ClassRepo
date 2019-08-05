using System;
using System.Collections.Generic;
using System.Text;

namespace PolyInher
{
    public class Poodle : Dog
    {
        public Poodle(int weight, string gender, bool isBourgeuis, bool isNootered) 
            : base(weight, gender, isNootered)
        {
            this.IsBourgeuis = isBourgeuis;
        }

        public Poodle(int weight, string gender, bool isNootered) 
            : base(weight, gender, isNootered)
        {

        }

        public bool IsBourgeuis { get; set; }


    }
}

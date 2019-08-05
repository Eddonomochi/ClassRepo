using System;
using System.Collections.Generic;
using System.Text;

namespace OOPYouKknowMe
{
    public class Toy
    {
        // THE MOST COMMON WAY TO MAKE A PROPERTY
        // auto property : code snippet = prop
        public string Color { get; set; }

        // Property  : code snippet =  propfull
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        // YOU WILL NEVER SEE THIS PROPERTY IN C#
        private string _shape;
        public string GetShape()
        {
            return _shape;
        }
        public void SetShape(string value)
        {
            if (value.Length < 3)
            {
                return;
            }
            _shape = value;
        }

    }
}

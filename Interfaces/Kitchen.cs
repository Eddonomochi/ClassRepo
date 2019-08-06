using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Kitchen : IBake, IDishWasher
    {
        private bool _isWashing;

        public int Temp { get; private set; }

        public int Time { get; private set; }

        public void LoadDishWasher(IList<string> dishes)
        {
            foreach (var dish in dishes)
            {
                Console.WriteLine($"loading {dish}");
            }
        }

        public string Measure(string ingredient)
        {
            if (ingredient == "flour")
            {
                return "1 oz";
            }

            return "nada";
        }

        public void SetOven(int temp, int time)
        {
            Temp = temp;
            Time = time;
        }

        public void SetWash(bool isWashing)
        {
            var onOrOffMessage = isWashing ? "on" : "off";
            Console.WriteLine($"setting dish washer to: {onOrOffMessage}");
            _isWashing = isWashing;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IBake
    {
        int Temp { get; }
        int Time { get; }

        void SetOven(int temp, int time);
        string Measure(string ingredient);
    }
}

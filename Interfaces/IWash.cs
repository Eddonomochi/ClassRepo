using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IDishWasher
    {
        void LoadDishWasher(IList<string> dishes);
        void SetWash(bool isWashing);
    }
}

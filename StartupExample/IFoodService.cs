using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartupExample
{
    public interface IFoodService
    {
        Food GetFood(decimal payment);
    }
}

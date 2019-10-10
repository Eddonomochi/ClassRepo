using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCValidationAHBCJuly2019.Services
{
    public interface ITaxCalculator
    {
        double Calculate(double number);
    }

    public class WellsFargoTaxCalculator : ITaxCalculator
    {
        public double Calculate(double number)
        {
            return number * 1.15;
        }
    }
}

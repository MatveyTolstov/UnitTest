using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class PercentageCalculator
    {
        public static double CalculatePercentage(double total, double part)
        {
            return (part / total) * 100;
        }
    }
}

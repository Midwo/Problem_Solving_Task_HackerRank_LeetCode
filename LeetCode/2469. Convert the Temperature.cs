using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2469
    {
        ////(2469.) Convert the Temperature (EASY)
        public double[] ConvertTemperature(double celsius)
        {
            double[] result = new double[2];

            result[0] = celsius + 273.15;
            result[1] = celsius * 1.8 + 32;

            return result;
        }
    }
}

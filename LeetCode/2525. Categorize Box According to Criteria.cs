using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2525
    {
        ////(2525.) Categorize Box According to Criteria (EASY)
        public string CategorizeBox(int length, int width, int height, int mass)
        {
            long volume = (long)length * width * height;
            if (length >= 10000 || width >= 10000 || height >= 10000 || volume >= 1000000000)
            {
                if (mass >= 100)
                {
                    return "Both";
                }
                else
                {
                    return "Bulky";
                }
            }
            else if (mass >= 100)
            {
                return "Heavy";
            }
            else
            {
                return "Neither";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2544
    {
        ////(2544.) Alternating Digit Sum (EASY)
        public int AlternateDigitSum(int n)
        {
            int sumOne = 0;
            int sumTwo = 0;
            string nString = n.ToString();
            bool sumOneStatus = true;

            while (n != 0)
            {
                int temp = n%10;
                n /= 10;

                if (sumOneStatus)
                {
                    sumOne += temp;
                    sumOneStatus = false;
                }
                else
                {
                    sumTwo += temp;
                    sumOneStatus = true;
                }
            }

            if(nString.Length % 2 == 0)
            {
                return sumTwo - sumOne;
            }
            else
            {
                return sumOne - sumTwo;
            }
        }
    }
}

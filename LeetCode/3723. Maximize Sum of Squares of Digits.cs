using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3723
    {
        ////(3723.) Maximize Sum of Squares of Digits (MEDIUM)
        public string MaxSumOfSquares(int num, int sum)
        {
            StringBuilder sb = new StringBuilder();
            int currSum = 0;
            int copySum = sum;
            
            while (num > 0)
            {
                if(copySum - 9 >= 0)
                {
                    sb.Append('9');
                    copySum -= 9;
                    currSum += 9;
                }
                else
                {
                    sb.Append(copySum);
                    currSum += copySum;
                    copySum = 0;
                }

                num--;
            }

            return currSum == sum ? sb.ToString() : "";
        }
    }
}

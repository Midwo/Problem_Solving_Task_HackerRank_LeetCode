using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1927
    {
        ////(1927.) Sum Game (MEDIUM)
        public bool SumGame(string num)
        {
            int length = num.Length;
            int indexHalf = length / 2;
            int leftSum = 0;
            int rightSum = 0;
            int countLeftSpecial = 0;
            int countRightSpecial = 0;

            for (int index = 0; index < length; index++)
            {
                if (num[index] == '?')
                {
                    if (index < indexHalf)
                        countLeftSpecial++;
                    else
                        countRightSpecial++;
                }
                else
                {
                    int currValue = num[index] - '0';
                    if (index < indexHalf)
                        leftSum += currValue;
                    else
                        rightSum += currValue;
                }
            }

            return ((countLeftSpecial + countRightSpecial) % 2 == 1) || (leftSum - rightSum != (countRightSpecial - countLeftSpecial) * 9 / 2);
        }
    }
}

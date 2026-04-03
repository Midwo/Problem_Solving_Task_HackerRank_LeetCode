using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2829
    {
        ////(2829.) Determine the Minimum Sum of a k-avoiding Array (MEDIUM)
        public int MinimumSum(int n, int k)
        {
            int minSum = 1;
            int lastValue = 1;
            int[] newTable = new int[n];

            newTable[0] = 1;

            for (int index = 1; index < n; index++)
            {
                bool statusAdd = false;
                while (!statusAdd)
                {
                    lastValue++;
                    bool status = true;

                    for (int i = 0; i < index; i++)
                    {
                        if (newTable[i] + lastValue == k)
                        {
                            status = false; break;
                        }
                    }
                    if (status)
                    {
                        newTable[index] = lastValue;
                        minSum += lastValue;
                        statusAdd = true;
                    }
                }
            }

            return minSum;
        }
    }
}

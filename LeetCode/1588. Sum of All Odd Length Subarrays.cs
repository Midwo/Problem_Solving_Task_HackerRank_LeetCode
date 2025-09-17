using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1588
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int howMany = 1;
            int sum = 0;

            while (howMany <= arr.Length) 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int currValue = 0;
                    if (howMany + i <= arr.Length)
                    {
                        for (int j = i; j < howMany + i; j++)
                        {
                            currValue += arr[j];
                        }
                        sum += currValue;
                    }
                }

                howMany += 2;
            }

            return sum;
        }

    }
}

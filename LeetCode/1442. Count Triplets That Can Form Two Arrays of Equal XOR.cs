using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1442
    {
        ////(1442.) Count Triplets That Can Form Two Arrays of Equal XOR (MEDIUM)
        public int CountTriplets(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        int tempA = 0;
                        int tempB = 0;

                        for (int currI = i; currI < j; currI++)
                        {
                            tempA ^= arr[currI];
                        }
                        for (int currJ = j; currJ <= k; currJ++)
                        {
                            tempB ^= arr[currJ];
                        }

                        if (tempA == tempB)
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}

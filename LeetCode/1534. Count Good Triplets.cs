using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1534
    {
        ////(1534.) Count Good Triplets (EASY)
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            int length = arr.Length;

            for (int i = 0; i < length - 2; i++)
            {
                for (int j = i + 1; j < length - 1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a)
                    {
                        for (int k = j + 1; k < length; k++)
                        {
                            if (Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            {
                                count++;
                            }
                        }
                    }
                } 
            }

            return count;
        }
    }
}

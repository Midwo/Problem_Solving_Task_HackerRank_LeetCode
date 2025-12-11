using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3618
    {
        ////(3618.) Split Array by Prime Indices (MEDIUM)
        public long SplitArray(int[] nums)
        {
            bool[] isPrime = new bool[111000];
            for (int i = 0; i < 111000; i++)
            {

                isPrime[i] = true;

            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < 111000; i++)
            {
                if (isPrime[i])
                {
                    for (int multiple = i+i; multiple < 111000; multiple +=i )
                    {
                        isPrime[multiple] = false;
                    }
                }
            }
                           
            long sumA = 0;
            long sumB = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (isPrime[i] == true)
                {
                    sumA += nums[i];
                }
                else
                {
                    sumB += nums[i];
                }
            }

            return Math.Abs(sumA - sumB);
        }
    }
}


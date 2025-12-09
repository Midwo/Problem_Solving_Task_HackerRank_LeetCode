using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3079
    {
        ////(3079.) Find the Sum of Encrypted Integers (EASY)
        public int SumOfEncryptedInt(int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                int tempNum = num;
                int maxValue = 0;
                int howLong = 0;
                while (tempNum != 0)
                {
                    int moduloNum = tempNum % 10;
                    maxValue = maxValue < moduloNum? moduloNum : maxValue;
                    tempNum /= 10;
                    howLong++;  
                }
                int currSum = maxValue;
                for (int i = 1; i < howLong; i++)
                {
                    currSum = currSum * 10 + maxValue;
                }
                sum += currSum;
            }
            return sum;
        }
    }
}

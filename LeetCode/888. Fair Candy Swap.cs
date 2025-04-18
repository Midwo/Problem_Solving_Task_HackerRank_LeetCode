using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_888
    {
        ////(888.) Fair Candy Swap (EASY)
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            int aliceSum = 0;
            int bobSum = 0;
            int aliceLength = aliceSizes.Length;
            int bobLength = bobSizes.Length;

            for (int i = 0; i < aliceLength; i++)
            {
                aliceSum += aliceSizes[i];
            }

            for (int i = 0; i < bobLength; i++)
            {
                bobSum += bobSizes[i];
            }

            if (bobSum == aliceSum) 
            {
                return new int[] { };  
            } 

            for(int i = bobLength-1; i >= 0; i--)
            {
                int tempCurrBobValue = bobSizes[i];
                for(int j = 0; j < aliceLength; j++)
                {
                    int tempCurrAliceValue = aliceSizes[j];
                    int currBobSum = bobSum - tempCurrBobValue + tempCurrAliceValue;
                    int currAliceSum = aliceSum - tempCurrAliceValue + tempCurrBobValue;
                    if (currBobSum == currAliceSum)
                    {
                        return new int[] {tempCurrAliceValue, tempCurrBobValue };
                    }
                }
            }

            return new int[] { };
        }
    }
}

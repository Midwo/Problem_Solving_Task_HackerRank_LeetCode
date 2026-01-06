using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1833
    {
        ////(1833.) Maximum Ice Cream Bars (MEDIUM)
        public int MaxIceCream(int[] costs, int coins)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach (int cost in costs)
            {
                max = max < cost ? cost : max;
                min = min > cost ? cost : min;
            }

            int[] cntArr = new int[max + 1];

            foreach (int cost in costs)
            {
                cntArr[cost]++;
            }
            int quantityCounter = 0;
            int currCount = 0;
            int currSum = 0;
            ////indexCntArr == Value
            for (int indexCntArr = min; indexCntArr < max+1; indexCntArr++)
            {
                currCount = cntArr[indexCntArr];
                if (currCount > 0)
                {
                    currSum = indexCntArr * currCount;
                    if (currSum <= coins)
                    {
                        quantityCounter += currCount;
                        coins -= currSum;
                        if(coins < indexCntArr + 1)
                        {
                            return quantityCounter;
                        }
                    }
                    else
                    {
                        quantityCounter += coins / indexCntArr;
                        return quantityCounter;
                    }
                }
            }

            return quantityCounter;
        }
    }
}

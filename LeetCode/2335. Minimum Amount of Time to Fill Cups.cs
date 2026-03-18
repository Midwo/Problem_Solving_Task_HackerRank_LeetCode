using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2335
    {
        ////(2335.) Minimum Amount of Time to Fill Cups (EASY)
        public int FillCups(int[] amount)
        {
            int minValue = amount[0];
            int maxValue = amount[1];
            int medianeValue = amount[2];
            int cups = 0;
            int currMax = int.MaxValue;

            if (maxValue < 1 && minValue < 1 && medianeValue < 1)
            {
                return 0;
            }

            while (currMax != 0)
            {
                if (minValue > maxValue)
                {
                    int temp = minValue;
                    minValue = maxValue;
                    maxValue = temp;
                    if(medianeValue > maxValue)
                    {
                        temp = medianeValue;
                        medianeValue = maxValue;
                        maxValue = temp;
                    }
                }
                else if(minValue > medianeValue)
                {
                    int temp = minValue;
                    minValue = medianeValue;
                    medianeValue = temp;
                    if (minValue > maxValue)
                    {
                        temp = minValue;
                        minValue = maxValue;
                        maxValue = temp;
                    }
                }
                else
                {
                    if (medianeValue > maxValue)
                    {
                        int temp = medianeValue;
                        medianeValue = maxValue;
                        maxValue = temp;
                    }
                }

                //int howManyFillMaxNow = medianeValue - minValue;

                maxValue--;
                medianeValue--;
                cups++;

                if (maxValue < 1 && minValue < 1 && medianeValue < 1)
                {
                    break;
                }
            }

            return cups;
        }
    }
}

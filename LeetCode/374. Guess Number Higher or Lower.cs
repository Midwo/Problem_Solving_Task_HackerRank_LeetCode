using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_374
    {
        ////(374.) Guess Number Higher or Lower
        public int GuessNumber(int n)
        {
            int pick = -1;
            int maxValue = int.MaxValue;
            int minValue = 1;
            int midValue = 1;
            pick = guess(maxValue);
            if (pick == 0) { return maxValue; }
            else
            {
                while (pick != 0)
                {
                    if (maxValue % 2 == 0)
                    {
                        midValue = Convert.ToInt32(((long)maxValue + (long)minValue) / 2);
                        pick = guess(midValue);
                        if (pick == 0)
                        {
                            return midValue;
                        }
                        else if (pick == -1)
                        {
                            maxValue = midValue;
                        }
                        else
                        {
                            minValue = midValue;
                        }
                    }
                    else
                    {
                        midValue = Convert.ToInt32(((long)maxValue + (long)minValue) / 2);
                        pick = guess(midValue);
                        if (pick == 0)
                        {
                            return midValue;
                        }
                        else if (pick == -1)
                        {
                            maxValue = midValue;
                        }
                        else
                        {
                            minValue = midValue;
                        }
                    }
                }
            }
            return n;
        }

        private int guess(int num)
        {
            int pick = 1702766719;
            if (num > pick) pick =-1;
            else if (num < pick) pick = 1;
            else pick = 0;
            return pick;
        }
    }
}

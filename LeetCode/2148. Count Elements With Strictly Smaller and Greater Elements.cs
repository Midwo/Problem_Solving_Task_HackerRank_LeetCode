using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2148
    {
        ////(2148.) Count Elements With Strictly Smaller and Greater Elements (EASY)
        public int CountElements(int[] nums)
        {
            int countMin = 0;
            int countMax = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            if (nums.Length < 3)
            {
                return 0;
            }

            foreach (var item in nums)
            {
                if (max <= item)
                {
                    if (max < item)
                    {
                        max = item;
                        countMax = 1;
                    }
                    else
                    {
                        countMax++;
                    }
                }
                if(min >= item)
                {
                    if (min > item)
                    {
                        min = item;
                        countMin = 1;
                    }
                    else
                    {
                        countMin++;
                    }
                }
            }

            if (min == max)
            {
                return 0;
            }

            return nums.Length - countMin - countMax;
        }
    }
}

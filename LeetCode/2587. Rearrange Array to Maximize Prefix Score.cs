using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2587
    {
        ////(2587.) Rearrange Array to Maximize Prefix Score (MEDIUM)
        public int MaxScore(int[] nums)
        {
            int countNumbers = 0;
            long currValue = 0;

            Array.Sort(nums, (a, b) => b.CompareTo(a));

            foreach (var number in nums)
            {
                currValue += number;
                if(currValue > 0)
                {
                    countNumbers++;
                }
                else
                {
                    return countNumbers;
                }

            }

            return countNumbers;
        }
    }
}

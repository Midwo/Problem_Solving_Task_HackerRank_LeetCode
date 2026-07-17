using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2091
    {
        ////(2091.) Removing Minimum and Maximum From Array (MEDIUM)
        public int MinimumDeletions(int[] nums)
        {
            int length = nums.Length;
            int minDeletions = length;
            int minIndex = -1;
            int maxIndex = -1;
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int index = 0; index < length; index++)
            {
                int num = nums[index];
                if(num > maxValue)
                {
                    maxValue = num;
                    maxIndex = index;
                }
                if(num < minValue)
                {
                    minValue = num;
                    minIndex = index;
                }
            }

            minDeletions = Math.Min(minDeletions, Math.Max(minIndex, maxIndex)+1);
            minDeletions = Math.Min(minDeletions, length - Math.Min(minIndex, maxIndex));

            if(minIndex < maxIndex)
            {
                minDeletions = Math.Min(minDeletions, minIndex+1 + length-maxIndex);
            }
            else if(minIndex > maxIndex)
            {
                minDeletions = Math.Min(minDeletions, maxIndex+1 + length - minIndex);
            }

            return minDeletions;
        }
    }
}

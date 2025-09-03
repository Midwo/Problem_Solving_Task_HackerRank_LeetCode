using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3194
    {
        ////(3194.) Minimum Average of Smallest and Largest Elements (EASY)
        public double MinimumAverage(int[] nums)
        {
            double minValue = int.MaxValue;
            int index = 0;
            int length = nums.Length-1;

            Array.Sort(nums);

            while (index <= (length)/ 2) 
            {
                minValue = Math.Min((double)(nums[index] + nums[length-index])/2, minValue);
                index++;
            }

            return minValue;
        }
    }
}

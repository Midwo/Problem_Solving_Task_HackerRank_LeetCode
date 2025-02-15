using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_414
    {
        ////(414.) Third Maximum Number (EASY)
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int howLong = nums.Length;
            int place;
            int currValue;
            place = 1;
            currValue = nums[howLong - 1];
            for (int i = howLong-2; i >= 0; i--) 
            {
                if (nums[i] != currValue)
                {
                    place++;
                    if (place == 3)
                    {
                        return nums[i];
                    }
                    else
                    {
                        currValue = nums[i];
                    }
                }
            }
            if (place <= 3) 
            {
                return nums[howLong-1];
            }
            return 1;
        }
    }
}

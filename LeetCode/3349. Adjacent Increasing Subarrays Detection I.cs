using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3349
    {
        ////(3349.) Adjacent Increasing Subarrays Detection I (EASY)
        public bool HasIncreasingSubarrays(IList<int> nums, int k)
        {
            int countIncreasing = 1;
            int lastValue = int.MaxValue;
            int length = nums.Count;
            if (k == 1)
            {
                return true;
            }

            for (int i = 0; i < length; i++) 
            {
                int temp = nums[i];
                if (i + k >= length)
                {
                    return false;
                }
                else if (lastValue < temp)
                {
                    countIncreasing++;
                    if(countIncreasing >= k)
                    {
                        bool status = true;
                        int currLastValue = nums[i+1];
                        for (int j = i+2; j <= i+k; j++)
                        {
                            if(currLastValue >= nums[j])
                            {
                                status = false;
                                break;
                            }
                            currLastValue = nums[j];
                        }
                        if (status)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    countIncreasing = 1;
                }
                lastValue = temp;
            }

            return false;
        }
    }
}

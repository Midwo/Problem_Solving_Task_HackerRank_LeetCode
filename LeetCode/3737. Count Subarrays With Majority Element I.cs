using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3737
    {
        ////(3737.) Count Subarrays With Majority Element I (MEDIUM)
        public int CountMajoritySubarrays(int[] nums, int target)
        {
            int lengthNums = nums.Length;

            int countSubarraysWithMajoritiyEl = 0;

            for (int index = 0; index < lengthNums; index++)
            {
                int diff = 0;
                
                for(int inIndex = index; inIndex < lengthNums; inIndex++)
                {
                    if (nums[inIndex] == target)
                        diff--;
                    else
                        diff++;

                    if(diff < 0)
                    {
                        countSubarraysWithMajoritiyEl++;
                    }

                    if(diff - (lengthNums-index) >= 0)
                    {
                        break;
                    }
                }  
            }

            return countSubarraysWithMajoritiyEl;
        }
    }
}

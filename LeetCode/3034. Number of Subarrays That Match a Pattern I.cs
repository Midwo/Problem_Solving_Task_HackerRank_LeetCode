using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3034
    {
        ////(3034.) Number of Subarrays That Match a Pattern I (MEDIUM)
        public int CountMatchingSubarrays(int[] nums, int[] pattern)
        {
            int countMatchingSubbarrays = 0;
            int lengthNums = nums.Length;
            int lengthPattern = pattern.Length;

            for (int indexStart = 0; indexStart < lengthNums - lengthPattern; indexStart++)
            {
                bool status = true;
                for (int indexPattern = 0; indexPattern < lengthPattern; indexPattern++)
                {
                    switch (pattern[indexPattern])
                    {
                        case 1:
                            if (nums[indexStart+indexPattern+1] <= nums[indexStart+indexPattern])
                                status = false;
                            break;
                        case 0:
                            if (nums[indexStart + indexPattern + 1] != nums[indexStart + indexPattern])
                                status = false;
                            break;
                        case -1:
                            if (nums[indexStart + indexPattern + 1] >= nums[indexStart + indexPattern])
                                status = false;
                            break;
                    }
                    if (!status)
                        break;
                }
                if (status)
                    countMatchingSubbarrays++;
            }

            return countMatchingSubbarrays;
        }
    }
}

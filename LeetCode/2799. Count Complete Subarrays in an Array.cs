using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2799
    {
        ////(2799.) Count Complete Subarrays in an Array (MEDIUM)
        public int CountCompleteSubarrays(int[] nums)
        {
            int countCompleteSubarrays = 0;

            HashSet<int> distinctValuesNums = new HashSet<int>();

            foreach (int number in nums) 
            {
                distinctValuesNums.Add(number);
            }

            for (int indexStart =  0; indexStart < nums.Length; indexStart++)
            {
                HashSet<int> subarrayDistinctValues = new HashSet<int>();
                int currCompleteSubarrays = 0;
                for (int index = indexStart; index < nums.Length; index++)
                {
                    subarrayDistinctValues.Add(nums[index]);
                    if (subarrayDistinctValues.Count == distinctValuesNums.Count)
                    {
                        currCompleteSubarrays = nums.Length - index;

                        break;
                    }
                }
                countCompleteSubarrays += currCompleteSubarrays;
            }

            return countCompleteSubarrays;
        }
    }
}

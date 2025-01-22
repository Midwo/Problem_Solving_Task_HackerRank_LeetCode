using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_217
    {
        ////217. Contains Deplicate(EASY)
        public bool ContainsDuplicate(int[] nums)
        {
            int howManyNums = nums.Count();
            if (howManyNums == 0)
            {
                return false;
            }
            Dictionary<int, int> dictionaryCountingReps = new Dictionary<int, int>();

            for (int i = 0; i < howManyNums; i++)
            {
                if (dictionaryCountingReps.ContainsKey(nums[i]))
                {
                    dictionaryCountingReps[nums[i]] += 1;
                    if (dictionaryCountingReps[nums[i]] >= 2)
                    {
                        return true;
                    }
                }
                else
                {
                    dictionaryCountingReps.Add(nums[i], 1);
                }
            }
            return false;
            ////Alternative, low memory consumption:
            //int howManyNums = nums.Count();
            //if (howManyNums == 0)
            //{
            //    return false;
            //}
            //Array.Sort(nums);
            //for (int i = 0; i < howManyNums - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1])
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}

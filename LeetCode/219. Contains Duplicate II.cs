using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_219
    {
        ////219. Contains Duplicate II (EASY)
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int howManyNums = nums.Count();
            Dictionary<int, int> dictionaryIndexNumbers = new Dictionary<int, int>();
            for (int i = 0; i < howManyNums; i++)
            {
                if (dictionaryIndexNumbers.ContainsKey(nums[i]))
                {
                    if (i - dictionaryIndexNumbers[nums[i]] <= k)
                    {
                        return true;
                    }
                }
                dictionaryIndexNumbers[nums[i]] = i;
            }
            return false;

            ////Alternative, low memory consumption:
            //int howManyNums = nums.Count();
            //int howLongTwoLoop = 0;
            //int currI = 0;
            //if (howManyNums <= 1 || k == 0)
            //{
            //    return false;
            //}
            //for (int i = 0; i < howManyNums - 1; i++)
            //{
            //    currI = nums[i];
            //    howLongTwoLoop = i + k >= howManyNums ? howManyNums - 1 : i + k;
            //    for (int j = i + 1; j <= howLongTwoLoop; j++)
            //    {
            //        if (currI == nums[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
        }
    }
}

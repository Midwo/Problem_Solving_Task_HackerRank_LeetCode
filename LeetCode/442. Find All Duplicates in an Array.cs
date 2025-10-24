using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_442
    {
        ////(442.) Find All Duplicates in an Array (MEDIUM)
        public IList<int> FindDuplicates(int[] nums)
        {
            ////Solution 1
            ////3ms, Beasts: 75.77%, Memory: 69.25MB, Beats: 71.13%

            IList<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                {
                    result.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] = -nums[Math.Abs(nums[i]) - 1];
                }
            }

            return result;

            ////Solution 2
            ////27ms, Beats: 24.74%, Memory: 72.00MB, Beats: 6.70%

            //HashSet<int> checkNumbers = new HashSet<int>();
            //IList<int> resultList = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!checkNumbers.Add(nums[i]))
            //    {
            //        resultList.Add(nums[i]);
            //    }
            //}

            //return resultList.ToList();
        }
    }
}

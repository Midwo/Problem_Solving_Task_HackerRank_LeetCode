using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_34
    {
        ////(34.) Find First and Last Position of Element in Sorted Array
        public int[] SearchRange(int[] nums, int target)
        {
            int leftBracketIndex = BracketSearchIndex(nums, target);
            int rightBracketIndex = BracketSearchIndex(nums, target + 1);

            if (leftBracketIndex == rightBracketIndex)
            {
                return new int[] { -1, -1 };
            }
            else
            {
                return new int[] { leftBracketIndex, rightBracketIndex - 1 };
            }

            ////Alternative -- function available via list: indexOf/LastIndexOf
            //List<int> listNums = nums.ToList();

            //return new int[] { listNums.IndexOf(target), listNums.LastIndexOf(target) };

        }

        private int BracketSearchIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length;

            while (left < right)
            {
                int middle = (left + right) / 2;

                if (nums[middle] >= target)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }

            }

            return left;
        }
    }
}

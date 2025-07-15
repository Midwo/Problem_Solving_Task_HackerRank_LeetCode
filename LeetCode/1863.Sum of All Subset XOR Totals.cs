using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1863
    {
        ////(1863.) Sum of All Subset XOR Totals (EASY)

        private int sumXor;
        public int SubsetXORSum(int[] nums)
        {
            dfsSubsetXORSum(nums, 0, 0);

            return sumXor;
        }

        private void dfsSubsetXORSum(int[] nums, int index, int currentXor)
        {
            sumXor += currentXor;


            for (int i = index; i < nums.Length; i++)
            {
                currentXor ^= nums[i];

                dfsSubsetXORSum(nums, i + 1, currentXor);

                currentXor ^= nums[i];
            }

        }

    }
}

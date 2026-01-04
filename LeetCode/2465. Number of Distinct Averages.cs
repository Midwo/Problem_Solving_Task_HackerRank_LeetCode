using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2465
    {
        ////(2465.) Number of Distinct Averages (EASY)
        public int DistinctAverages(int[] nums)
        {
            Array.Sort(nums);
            HashSet<int> countDistinctAverages = new HashSet<int>();
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                countDistinctAverages.Add((nums[left] + nums[right]));
                left++;
                right--;
            }

            return countDistinctAverages.Count;
        }
    }
}

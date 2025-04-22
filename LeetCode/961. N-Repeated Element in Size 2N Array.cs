using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_961
    {
        ////(961.) N-Repeated Element in Size 2N Array (EASY)
        public int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> dictionaryNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionaryNums.ContainsKey(nums[i]))
                {
                    return nums[i];
                }
                else
                {
                    dictionaryNums.Add(nums[i], 1);
                }
            }

            return 0;
        }
    }
}

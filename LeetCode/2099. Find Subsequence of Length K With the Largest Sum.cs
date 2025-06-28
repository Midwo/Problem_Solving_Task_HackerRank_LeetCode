using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2099
    {
        ////(2099.) Find Subsequence of Length K With the Largest Sum (EASY)
        public int[] MaxSubsequence(int[] nums, int k)
        {
            int[] result = new int[k];
            int length = nums.Length;

            if (k == length)
            {
                return nums;
            }

            Dictionary<int, int> dictionaryIndexValue = new Dictionary<int, int>();

            for (int i = 0; i < length; i++)
            {
                dictionaryIndexValue.Add(i, nums[i]);
            }

            Dictionary<int, int> dictionaryIndexValue1 = dictionaryIndexValue.OrderByDescending(x => x.Value).ThenByDescending(y => y.Key).ToDictionary<int, int>();
            Dictionary<int, int> dictionaryIndexValue2 = new Dictionary<int, int>();
            foreach (var item in dictionaryIndexValue1)
            {
                if (k <= 0)
                {
                    break;
                }

                result[k - 1] = item.Value;
                dictionaryIndexValue2.Add(item.Key, item.Value);

                k--;
            }

            dictionaryIndexValue1 = dictionaryIndexValue2.OrderBy(x => x.Key).ToDictionary<int, int>();


            return dictionaryIndexValue1.Values.ToArray();
        }
    }
}

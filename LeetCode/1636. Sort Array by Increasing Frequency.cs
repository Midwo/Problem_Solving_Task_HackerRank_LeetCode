using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1636
    {
        ////(1636.) Sort Array by Increasing Frequency (EASY)
        public int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> dictionaryCountNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                if (dictionaryCountNums.ContainsKey(nums[i]))
                {
                    dictionaryCountNums[nums[i]]++;
                }
                else
                {
                    dictionaryCountNums.Add(nums[i], 1);
                }
            }

            List<int> listValue = dictionaryCountNums.OrderBy(x => x.Value).ThenByDescending(x => x.Key).Select(x => x.Key).ToList();

            int index = 0;

            foreach (int num in listValue) 
            {
                for (int i = 0; i < dictionaryCountNums[num]; i++)
                {
                    nums[index] = num;
                    index++;
                }
            }

            return nums;
        }
    }
}

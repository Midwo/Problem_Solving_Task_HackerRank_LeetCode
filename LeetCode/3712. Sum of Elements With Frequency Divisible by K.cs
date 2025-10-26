using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3712
    {
        ////(3712.) Sum of Elements With Frequency Divisible by K (EASY)
        public int SumDivisibleByK(int[] nums, int k)
        {
            ////Solution #1
            ////0ms, 100.00%

            Span<int> frequencyNums = stackalloc int[101];
            int sum = 0;

            foreach (var item in nums)
            {
                frequencyNums[item]++;
            }

            for (int i = 1; i < 101; i++)
            {
                if (frequencyNums[i] % k == 0)
                {
                    sum += i * frequencyNums[i];
                }
            }

            return sum;


            ////Solution #2
            ////1ms, Beats: 94.71%

            //int[] frequencyNums = new int[101];
            //int sum = 0;

            //foreach (var item in nums)
            //{
            //    frequencyNums[item]++;
            //}

            //for (int i = 1; i < 101; i++)
            //{
            //    if (frequencyNums[i] % k == 0)
            //    {
            //        sum += i * frequencyNums[i];
            //    }
            //}

            //return sum;


            ////Solution #3
            ////1ms, Beats: 94.71%

            //Dictionary<int, int> dictionaryNumsAndFrequency = new Dictionary<int, int>();
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (!dictionaryNumsAndFrequency.TryAdd(nums[i], 1))
            //    {
            //        dictionaryNumsAndFrequency[nums[i]]++;
            //    }
            //}

            //foreach (var item in dictionaryNumsAndFrequency)
            //{
            //    if (item.Value > 0 && item.Value % k == 0)
            //    {
            //        sum += item.Key * item.Value;
            //    }
            //}

            //return sum;
        }
    }
}

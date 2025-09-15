using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2956
    {
        ////(2956.) Find Common Elements Between Two Arrays (EASY)
        public int[] FindIntersectionValues(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dictionaryNums1Count = new Dictionary<int, int>();
            Dictionary<int, int> dictionaryNums2Count = new Dictionary<int, int>();
            int[] result = new int[2] { 0, 0 };

            for (int i = 0; i < nums1.Length; i++) 
            {
                if (dictionaryNums1Count.ContainsKey(nums1[i]))
                {
                    dictionaryNums1Count[nums1[i]]++;
                }
                else
                {
                    dictionaryNums1Count.Add(nums1[i], 1);
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionaryNums2Count.ContainsKey(nums2[i]))
                {
                    dictionaryNums2Count[nums2[i]]++;
                }
                else
                {
                    dictionaryNums2Count.Add(nums2[i], 1);
                }
            }

            foreach (var item in dictionaryNums1Count)
            {
                if (dictionaryNums2Count.ContainsKey(item.Key))
                {
                    result[0] += item.Value;
                }
            }
            foreach (var item in dictionaryNums2Count)
            {
                if (dictionaryNums1Count.ContainsKey(item.Key))
                {
                    result[1] += item.Value;
                }
            }

            return result;
        }
    }
}

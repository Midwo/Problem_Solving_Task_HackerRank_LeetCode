using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3843
    {
        ////(3843.) First Element with Unique Frequency (MEDIUM)
        public int FirstUniqueFreq(int[] nums)
        {
            Dictionary<int, int> freqNums = new Dictionary<int, int>();

            foreach (int num in nums) 
            {
                if (freqNums.ContainsKey(num))
                {
                    freqNums[num]++;
                }
                else
                {
                    freqNums.Add(num, 1);
                }
            }

            HashSet<int> allFreq = new HashSet<int>();
            HashSet<int> twoOrMoreFreq = new HashSet<int>();

            foreach (var item in freqNums) 
            {
                if (!allFreq.Add(item.Value))
                { 
                    twoOrMoreFreq.Add(item.Value);
                }
            }

            int seachrFreq = -1;
            foreach (var item in allFreq)
            {
                if (!twoOrMoreFreq.Contains(item))
                {
                    seachrFreq = item;
                    break;
                }
            }

            foreach (var item in freqNums)
            {
                if (item.Value == seachrFreq)
                {
                    return item.Key;
                }
            }

            return -1;
        }
    }
}

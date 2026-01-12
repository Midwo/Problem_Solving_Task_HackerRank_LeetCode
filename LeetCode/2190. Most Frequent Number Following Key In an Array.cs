using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2190
    {
        public int MostFrequent(int[] nums, int key)
        {
            Span<int> freq = stackalloc int[1001];
            
            for (int i = 0; i < nums.Length -1; i++)
            {
                if (nums[i] == key)
                {
                    freq[nums[i+1]]++;
                }
            }

            int maxFreq = 0;
            int valueMaxFreq = 0;
            
            for (int i = 1; i < 1001; i++) 
            { 
                int currFreq = freq[i];
                if (currFreq > maxFreq) 
                {
                    maxFreq = currFreq;
                    valueMaxFreq = i;
                }
            }

            return valueMaxFreq;
        }
    }
}

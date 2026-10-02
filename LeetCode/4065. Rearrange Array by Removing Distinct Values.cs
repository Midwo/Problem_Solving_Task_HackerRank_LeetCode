using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4065
    {
        ////(4065.) Rearrange Array by Removing Distinct Values (EASY)
        public int[] RearrangeArray(int[] nums)
        {
            int length = nums.Length;
            int[] result = new int[length];
            int[] countValues = new int[101];
            int maxValue = 0;
            int maxCount = 0;

            foreach (int num in nums) 
            {
                countValues[num]++;
                maxValue = maxValue < num ? num : maxValue;
                maxCount = maxCount < countValues[num] ? countValues[num] : maxCount;    
            }

            int indexResult = 0;
            
            for (int currCount = 1; currCount <= maxCount; currCount++)
            {
                for (int currNum = 1; currNum <= maxValue; currNum++)
                {
                    int count = countValues[currNum];
                    if (count >= currCount)
                        result[indexResult++] = currNum;
                }
            }

            return result;
        }
    }
}

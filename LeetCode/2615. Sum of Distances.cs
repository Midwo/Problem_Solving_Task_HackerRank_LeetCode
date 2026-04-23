using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2615
    {
        ////(2615.) Sum of Distances (MEDIUM)
        public long[] Distance(int[] nums)
        {
            var dictValuesAndIndexes = new Dictionary<int, List<int>>();
            int lengthNums = nums.Length;

            for (int i = 0; i < lengthNums; i++) 
            { 
                int currValue = nums[i];
                if (!dictValuesAndIndexes.TryAdd(currValue, [i]))
                {
                    dictValuesAndIndexes[currValue].Add(i);
                }
            }

            var resultListSumOfDistances = new long[lengthNums];

            foreach (var actualGroup in dictValuesAndIndexes)
            {
                var indexes = actualGroup.Value;
                int countIndexes = indexes.Count;

                if (countIndexes == 1)
                    continue;

                long[] prefixTable = new long[countIndexes];
                prefixTable[0] = indexes[0];

                for (int i = 1; i < countIndexes; i++) 
                {
                    prefixTable[i] = prefixTable[i - 1] + indexes[i];
                }
                
                for (int i = 0; i < countIndexes; i++)
                {
                    int currIndex = indexes[i];
                    
                    long left = (long)i*currIndex - (i > 0 ? prefixTable[i - 1] : 0);
                    long right = (prefixTable[countIndexes - 1]) - prefixTable[i] - (long)(countIndexes - i - 1) * currIndex;

                    resultListSumOfDistances[currIndex] = left + right;
                }
            }

            return resultListSumOfDistances;
        }
    }
}

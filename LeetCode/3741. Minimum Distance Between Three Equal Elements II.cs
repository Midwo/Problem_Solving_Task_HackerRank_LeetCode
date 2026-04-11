using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3741
    {
        ////(3741.) Minimum Distance Between Three Equal Elements II (MEDIUM)
        public int MinimumDistance(int[] nums)
        {
            Dictionary<int, int[]> numberAndIndices = new Dictionary<int, int[]>();
            int minDistance = int.MaxValue;

            for (int numsIndex = 0; numsIndex < nums.Length; numsIndex++)
            {
                int currValue = nums[numsIndex];
                if (numberAndIndices.ContainsKey(currValue))
                {
                    if (numberAndIndices[currValue][1] > -1)
                    {
                        minDistance = Math.Min(minDistance, (numsIndex - numberAndIndices[currValue][0]) * 2);
                        numberAndIndices[currValue][0] = numberAndIndices[currValue][1];
                        numberAndIndices[currValue][1] = numsIndex;
                    }
                    else
                    {
                        numberAndIndices[currValue][1] = numsIndex;
                    }
                }
                else
                {
                    numberAndIndices.Add(currValue, new int[2] { numsIndex, -1 });
                }
            } 

            if(minDistance == int.MaxValue)
            {
                return -1;
            }

            return minDistance;
        }
    }
}

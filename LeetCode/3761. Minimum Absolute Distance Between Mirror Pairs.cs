using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3761
    {
        /////(3761.) Minimum Absolute Distance Between Mirror Pairs (MEDIUM)
        public int MinMirrorPairDistance(int[] nums)
        {
            ////Solution 1 (Better)
            //// O(n) time, O(n) memory.
            //// Uses dictionary mapping reversed numbers to last index.
            //// Single pass, scalable, handles worst-case inputs.

            var dictionaryLastReverseNums = new Dictionary<int, int>();
            var minDistance = int.MaxValue;

            for (int index = 0; index < nums.Length; index++)
            {
                var currNum = nums[index];
                var reverseNum = 0;

                if (dictionaryLastReverseNums.ContainsKey(currNum))
                {
                    minDistance = Math.Min(minDistance, index - dictionaryLastReverseNums[currNum]);
                }

                while (currNum > 0)
                {
                    reverseNum *= 10;
                    reverseNum += currNum % 10;
                    currNum /= 10;
                }

                if (!dictionaryLastReverseNums.TryAdd(reverseNum, index))
                {
                    dictionaryLastReverseNums[reverseNum] = index;
                }
            }


            if (minDistance == int.MaxValue)
                return -1;

            return minDistance;



            ////Solution 2 (Poor)
            // O(n^2) time in worst case.
            // Works only because early-exit triggers for minDistance == 1.
            // Not scalable for large inputs; kept for comparison and learning.

            //var dictionaryNumsList = new Dictionary<int, List<int>>();
            //var numsLength = nums.Length;

            //for(int index = 0; index < numsLength; index++)
            //{ 
            //    var currNum = nums[index];
            //    if (!dictionaryNumsList.TryAdd(currNum, [index]))
            //    {
            //        dictionaryNumsList[currNum].Add(index);
            //    }
            //}

            //var minDistance = int.MaxValue;

            //for (int index = 0; index < numsLength; index++)
            //{
            //    var currNum = nums[index];
            //    var reverseNum = 0;

            //    while(currNum > 0)
            //    {
            //        reverseNum *= 10;
            //        reverseNum += currNum % 10;
            //        currNum /= 10;
            //    }

            //    if (dictionaryNumsList.ContainsKey(reverseNum))
            //    {
            //        foreach (var item in dictionaryNumsList[reverseNum])
            //        {
            //            if(index < item)
            //            {
            //                minDistance = Math.Min(minDistance, item - index);
            //            }
            //        }
            //        if (minDistance == 1)
            //            return 1;
            //    }
            //}

            //    if (minDistance == int.MaxValue)
            //    return -1;

            //return minDistance;
        }
    }
}

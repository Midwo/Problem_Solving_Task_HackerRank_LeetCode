using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3507
    {
        ////(3507.) Minimum Pair Removal to Sort Array I (EASY)
        public int MinimumPairRemoval(int[] nums)
        {
            int minimumPairRemoval = 0;
            List<int> listNums = nums.ToList();
            bool statusNonDecreasing = false;
            int minimumSumPair;
            int indexRightPair = int.MaxValue;
            int lastValue;
            int currValue;
            int currSumPair;

            while (!statusNonDecreasing)
            {
                statusNonDecreasing = true;
                lastValue = listNums[0];
                minimumSumPair = int.MaxValue;

                for (int i = 1; i < listNums.Count; i++)
                {
                    currValue = listNums[i];
                    if (lastValue > currValue)
                    {
                        statusNonDecreasing = false;
                    }
                    currSumPair = lastValue + currValue;
                    if (currSumPair < minimumSumPair)
                    {
                        minimumSumPair = currSumPair;
                        indexRightPair = i;
                    }
                    lastValue = currValue;
                }
                if (statusNonDecreasing) { return minimumPairRemoval; }
                listNums[indexRightPair - 1] = minimumSumPair;
                listNums.RemoveAt(indexRightPair);
                minimumPairRemoval++;
            }

            return minimumPairRemoval;
        }
    }
}

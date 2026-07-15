using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2389
    {
        ////(2389.) Longest Subsequence With Limited Sum (EASY)
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            int lengthNums = nums.Length;
            Array.Sort(nums);
            int lengthQueries = queries.Length;
            int[] resultTableMaxLength = new int[lengthQueries];
            int minValue = nums[0];
            for (int indexQueries = 0; indexQueries < lengthQueries; indexQueries++)
            {
                long currSum = 0;
                int currMax = queries[indexQueries];

                if (minValue > currMax)
                {
                    resultTableMaxLength[indexQueries] = 0;
                }
                else
                {
                    int indexNum = 0;
                    for (; indexNum < lengthNums; indexNum++)
                    {
                        currSum += nums[indexNum];
                        if (currSum > currMax)
                        {
                            break;
                        }
                        resultTableMaxLength[indexQueries] = indexNum + 1;
                    }
                }
            }

            return resultTableMaxLength;
        }
    }
}

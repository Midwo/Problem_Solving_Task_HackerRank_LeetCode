using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1769
    {
        ////(1769.) Minimum Number of Operations to Move All Balls to Each Box (MEDIUM)
        public int[] MinOperations(string boxes)
        {
            int leftSumOperations = 0;
            int rightSumOperations = 0;
            int rightSumBallons = 0;
            int leftSumBallons = 0;
            int length = boxes.Length;
            int[] result = new int[length];

            for (int i = length - 1; i > 0; i--)
            {
                rightSumOperations += rightSumBallons;
                if (boxes[i] == '1')
                {
                    rightSumOperations++;
                    rightSumBallons++;
                }
            }

            result[0] = rightSumOperations;

            for (int i = 1; i < length; i++)
            {
                leftSumOperations += leftSumBallons;
                if (boxes[i - 1] == '1')
                {
                    leftSumOperations++;
                    leftSumBallons++;
                }

                if (boxes[i] == '1')
                {
                    rightSumOperations--;
                    rightSumBallons--;
                }
                rightSumOperations -= rightSumBallons;

                result[i] = leftSumOperations + rightSumOperations;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2679
    {
        ////(2679.) Sum in a Matrix (MEDIUM)
        public int MatrixSum(int[][] nums)
        {
            int rows = nums.Length;
            int cols = nums[0].Length;

            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                Array.Sort(nums[indexRow]);
            }

            int sum = 0;

            for (int indexCol = 0; indexCol < cols; indexCol++)
            {
                int maxValue = 0;
                for (int indexRow = 0; indexRow < rows; indexRow++)
                {
                    maxValue = maxValue < nums[indexRow][indexCol] ? nums[indexRow][indexCol] : maxValue;
                }
                sum += maxValue;
            }

            return sum;
        }
    }
}

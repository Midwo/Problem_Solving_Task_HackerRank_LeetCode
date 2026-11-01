using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_453
    {
        ////(453.) Minimum Moves to Equal Array Elements (MEDIUM)
        public int MinMoves(int[] nums)
        {
            /////Solution 1
            long sumValues = 0;
            int minValue = int.MaxValue;
            int length = nums.Length;

            foreach (int num in nums)
            {
                minValue = minValue > num ? num : minValue;
                sumValues += num;
            }

            return (int)(sumValues - length*minValue);


            ////Solution 2
            //int min = nums.Min();
            //int countDiff = 0;

            //foreach (int num in nums)
            //{
            //    countDiff += num - min;
            //}

            //return countDiff;
        }
    }
}

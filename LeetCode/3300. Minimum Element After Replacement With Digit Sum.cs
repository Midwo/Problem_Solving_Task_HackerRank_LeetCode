using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3300
    {
        ////(3300.) Minimum Element After Replacement With Digit Sum (EASY)
        public int MinElement(int[] nums)
        {
            //// 0ms, Beats: 100%

            int minValue = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                int currSum = 0;

                while(currValue > 0)
                {
                    currSum += currValue % 10;
                    currValue /= 10;
                }

                if (currSum < minValue)
                {
                    minValue = currSum;
                }
            }

            return minValue;


            //// 4ms, Beats: 35.42%

            //int minValue = int.MaxValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int currValue = 0;
            //    foreach (char item in nums[i].ToString())
            //    {
            //        currValue += int.Parse(item.ToString());
            //    }
            //    if (minValue > currValue)
            //    {
            //        minValue = currValue;
            //    }
            //}

            //return minValue;
        }
    }
}

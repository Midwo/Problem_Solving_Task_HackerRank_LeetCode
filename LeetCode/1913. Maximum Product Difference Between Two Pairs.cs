using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1913
    {
        ////(1913.) Maximum Product Difference Between Two Pairs (EASY)
        public int MaxProductDifference(int[] nums)
        {
            ////129ms, Beats: 57.41%
            //int length = nums.Length;
            //Array.Sort(nums);

            //return (nums[length - 1] * nums[length - 2] - nums[0] * nums[1]);

            //OR

            ////106ms, Beats: 96.30%
            int length = nums.Length;
            int firstMax = nums[0];
            int secondMax = int.MinValue;
            int firstMin = nums[0];
            int secondMin = int.MaxValue;

            for (int i = 1; i < length; i++)
            {
                int temp = nums[i];
                if (firstMax <= temp)
                {
                    if (firstMax < temp)
                    {
                        if (secondMax < firstMax)
                        {
                            secondMax = firstMax;
                        }
                        firstMax = temp;
                    }
                    else if (secondMax < firstMax)
                    {
                        secondMax = firstMax;
                    }

                }
                else if (secondMax < temp)
                {
                    secondMax = temp;
                }

                if (firstMin >= temp)
                {
                    if (firstMin > temp)
                    {
                        if (secondMin > firstMin)
                        {
                            secondMin = firstMin;
                        }
                        firstMin = temp;
                    }
                    else if (secondMin > firstMin)
                    {
                        secondMin = firstMin;
                    }
                }
                else if (secondMin > temp)
                {
                    secondMin = temp;
                }
            }

            return firstMax * secondMax - firstMin * secondMin;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_611
    {
        ////(611.) Valid Triangle Number (MEDIUM)
        public int TriangleNumber(int[] nums)
        {
            ////25ms, Beats: 98.53%
            int count = 0;
            int length = nums.Length;
            Array.Sort(nums);

            for (int i = length-1; i > 0; i--) 
            {
                int left = 0;
                int right = i - 1;
                int currValue = nums[i];

                while (left < right)
                {
                    if (nums[left] + nums[right] > currValue)
                    {
                        count += right - left;
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return count;

            //// Brute Force: 607ms, Beats: 11.76%
            //int count = 0;
            //int length = nums.Length;
            //Array.Sort(nums);
           
            //if(length < 3)
            //{
            //    return count;
            //}

            //for(int i = 0; i < length-2; i++)
            //{
            //    int currFirstValue = nums[i];
            //    for(int j = i+1; j < length-1; j++)
            //    {
            //        int secondValue = nums[j];
            //        for(int k = j+1; k < length; k++)
            //        {
            //            if(currFirstValue + secondValue > nums[k])
            //            {
            //                count++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}

            //return count;
        }
    }
}

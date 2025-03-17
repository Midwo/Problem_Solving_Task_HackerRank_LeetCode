using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_16
    {
        ////(16.) 3Sum Closest (MEDIUM)
        
        ////Two Pointer Ver. - Fast
        public int ThreeSumClosest(int[] nums, int target)
        {
            int resultSumCloset = int.MaxValue;
            int lengthNums = nums.Length;

            for (int i = 0; i < lengthNums; i++)
            {
                int leftPointerIndex = i+1;
                int rightPointerIndex = nums.Length-1;

                while(leftPointerIndex < rightPointerIndex)
                {
                    int currTempSum = nums[i] + nums[leftPointerIndex] + nums[rightPointerIndex];

                    if (target == currTempSum)
                    {
                        return currTempSum;
                    }
                    else if (Math.Abs(currTempSum - target) < Math.Abs(resultSumCloset - target))
                    {
                        resultSumCloset = currTempSum;
                    }

                    if (currTempSum > target)
                    {
                        rightPointerIndex--;
                    }
                    else
                    {
                        leftPointerIndex++;
                    }
                }
            }

            return resultSumCloset;


            ////Brutal Force - slow version
            
            ////Array.Sort(nums);
            //int currValue = int.MinValue;
            //int sumClosest = int.MaxValue;
            //int currDiff = int.MaxValue;
            //int result = int.MinValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        for (int k = j + 1; k < nums.Length; k++)
            //        {
            //            currValue = nums[i] + nums[j] + nums[k];

            //            if(target < 0)
            //            {
            //                if (currValue < 0)
            //                {
            //                    currDiff = Math.Abs(target - currValue);
            //                }
            //                else
            //                {
            //                    currDiff = Math.Abs(target - currValue);
            //                }
            //            }
            //            else
            //            {
            //                if(currValue < 0)
            //                {
            //                    currDiff = Math.Abs(currValue - target);
            //                }
            //                else
            //                {
            //                    currDiff = Math.Abs(target - currValue);
            //                }
            //            }
            //            if (currDiff < sumClosest)
            //            {
            //                sumClosest = currDiff;
            //                result = currValue;
            //                if (currDiff == 0)
            //                {
            //                    return currValue;
            //                }
            //            }
            //        }
            //    }
            //}

            //return result;
        }
    }
}

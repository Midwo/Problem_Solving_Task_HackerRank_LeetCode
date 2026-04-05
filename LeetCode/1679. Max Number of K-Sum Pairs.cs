using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1679
    {
        ////(1679.) Max Number of K-Sum Pairs (MEDIUM)
        public int MaxOperations(int[] nums, int k)
        {
            ////Solution 1 - Dictionary.
            
            Dictionary<int, int> dictionaryNumberCount = new Dictionary<int, int>();

            int countOperationsPair = 0;

            foreach (int num in nums) 
            {
                if (dictionaryNumberCount.ContainsKey(num))
                {
                    dictionaryNumberCount[num]++;
                }
                else
                {
                    dictionaryNumberCount.Add(num, 1);
                }
            }

            foreach (var item in dictionaryNumberCount) 
            {
                int seachrValue = k - item.Key;
                if (dictionaryNumberCount.ContainsKey(seachrValue))
                {
                    int minimumCount = Math.Min(dictionaryNumberCount[seachrValue], item.Value);
                    countOperationsPair += minimumCount;
                }
            }

            return countOperationsPair/2;


            ////Solution 2 - Array Sort
            //Array.Sort(nums);
            //int countOperationsPair = 0;

            //int length = nums.Length;

            //int indexLeft = 0;
            //int indexRight = length;

            //while (indexRight > indexLeft)
            //{
            //    int currIndex = (indexLeft + indexRight) / 2;

            //    if (nums[currIndex] > k)
            //    {
            //        indexRight = currIndex;
            //    }
            //    else
            //    {
            //        indexLeft = currIndex+1;
            //    }
            //}

            //indexRight--;
            //indexLeft = 0;

            //while (indexRight > indexLeft)
            //{
            //    int currSum = nums[indexRight] + nums[indexLeft];
            //    if (currSum > k)
            //    {
            //        indexRight--;
            //    }
            //    else if (currSum == k)
            //    {
            //        countOperationsPair++;
            //        indexLeft++;
            //        indexRight--;
            //    }
            //    else
            //    {
            //        indexLeft++;
            //    }
            //}

            //return countOperationsPair;
        }
    }
}

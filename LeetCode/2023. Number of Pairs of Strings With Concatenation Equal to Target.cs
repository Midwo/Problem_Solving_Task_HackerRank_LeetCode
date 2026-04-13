using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2023
    {
        ////(2023.) Number of Pairs of Strings With Concatenation Equal to Target (MEDIUM)
        public int NumOfPairs(string[] nums, string target)
        {
            ////Solution 1 - Better solution.
            Dictionary<string, int> dictionaryCountNums = new Dictionary<string, int>();
            int lengthTarget = target.Length;
            int numberOfPairs = 0;

            foreach (string item in nums)
            {
                if (dictionaryCountNums.ContainsKey(item))
                {
                    dictionaryCountNums[item]++;
                }
                else
                {
                    dictionaryCountNums.Add(item, 1);
                }
            }

            foreach (var item in nums)
            {
                if (target.StartsWith(item))
                {
                    int lengthString = item.Length;
                    string currTarget = target[lengthString..lengthTarget];

                    if (dictionaryCountNums.ContainsKey(currTarget))
                    {
                        if (currTarget == item)
                        {
                            numberOfPairs--;
                        }
                        numberOfPairs += dictionaryCountNums[target[lengthString..lengthTarget]];
                    }
                }
            }

            return numberOfPairs;

            ////Solution 2 - First things, simple.
            //int numsLength = nums.Length;
            //int lengthTarget = target.Length;
            //int[] tableLengthNums = new int[numsLength];
            //int numberOfPairs = 0;

            //for (int index = 0; index < numsLength; index++) 
            //{
            //    tableLengthNums[index] = nums[index].Length;
            //}

            //for (int index = 0; index < numsLength; index++)
            //{
            //    int currLength = tableLengthNums[index];
            //    if(currLength < lengthTarget && target.StartsWith(nums[index]))
            //    {
            //        int currLengthSeachr = lengthTarget - currLength;
            //        string currtText = nums[index];
            //        for (int indexLeft = 0; indexLeft < index; indexLeft++)
            //        {
            //            if (tableLengthNums[indexLeft] == currLengthSeachr && target.EndsWith(nums[indexLeft]))
            //            {
            //                numberOfPairs++;
            //            }
            //        }

            //        for (int indexRight = index+1; indexRight < numsLength; indexRight++)
            //        {
            //            if (tableLengthNums[indexRight] == currLengthSeachr && target.EndsWith(nums[indexRight]))
            //            {
            //                numberOfPairs++;
            //            }
            //        }
            //    }                
            //}

            //return numberOfPairs;
        }
    }
}

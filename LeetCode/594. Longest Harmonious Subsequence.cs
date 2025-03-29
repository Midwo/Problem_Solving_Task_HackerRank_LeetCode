using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_594
    {
        ////(594.) Longest Harmonious Subsequence (EASY)

        public int FindLHS(int[] nums)
        {
            ////Dictionary method
            var dictionaryNums = new Dictionary<int, int>();
            var result = 0;

            foreach (int num in nums)
            {
                //if (!dictionaryNums.TryAdd(num, 1))
                //{
                //    dictionaryNums[num]++;
                //}
                if (dictionaryNums.ContainsKey(num))
                {
                    dictionaryNums[num]++;
                }
                else
                {
                    dictionaryNums.Add(num, 1);                    
                }
            }

            foreach (int key in dictionaryNums.Keys)
            {
                if (dictionaryNums.ContainsKey(key + 1))
                {
                    result = Math.Max(result, dictionaryNums[key] + dictionaryNums[key + 1]);
                }
            }

            return result;

            //////SORT Method:
            //Array.Sort(nums);
            //int length = nums.Length;
            //bool saveToResult = false;
            //int currValueFirst = nums[0];
            //int countSecondValue = 0;
            //int currValueTwo = int.MinValue;
            //int result = 0;
            //int currMax = 1;
            //bool inLoop = false;
            
            //for (int i = 1; i < length; i++)
            //{
            //    //Console.WriteLine(nums[i]);
            //    if (currValueFirst == nums[i] || currValueFirst + 1 == nums[i])
            //    {
            //        inLoop = true;
            //        currMax++;
            //        if (currValueFirst + 1 == nums[i])
            //        {
            //            saveToResult = true;
            //            currValueTwo = nums[i];
            //            countSecondValue++;
            //        }
            //        if (saveToResult)
            //        {
            //            result = result < currMax ? currMax : result;   
            //        }
            //    }
            //    else 
            //    {
            //        if (nums[i]-1 == nums[i-1])
            //        {
            //            if (countSecondValue > 0)
            //            {
            //                currMax = countSecondValue + 1;
            //            }
            //            else
            //            {
            //                currMax = 1;
            //            }
            //            if (inLoop == false)
            //            {
            //                currValueFirst = nums[i];
            //                countSecondValue = 0;
            //            }
            //            else
            //            {
            //                if (!saveToResult)
            //                {
            //                    currValueFirst = nums[i-1];
            //                }
            //                else
            //                {
            //                    currValueFirst = currValueTwo;
            //                }
            //                countSecondValue = 1;
            //            }
            //            if (nums[i] == nums[i] - 1)
            //            {
            //                saveToResult = true;
            //            }
            //            else
            //            {
            //                saveToResult = false;
            //            }
            //        }
            //        else
            //        {
            //            saveToResult = false;
            //            currValueFirst = nums[i];
            //            countSecondValue = 0;
            //            inLoop = false;
            //            currMax = 1;
            //        }
            //    }     
            //}

            //if (length == 1)
            //{
            //    return 0;
            //}
            //return result;
        }
    }
}

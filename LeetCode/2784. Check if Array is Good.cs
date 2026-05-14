using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2784
    {
        ////(2784.) Check if Array is Good (MEDIUM)
        public bool IsGood(int[] nums)
        {
            ////Solution 1
            int length = nums.Length;
            var freqTable = new int[length]; 

            foreach (var num in nums)
            {
                if (num >= length)
                    return false;
                if (num < length - 1 && freqTable[num] > 0)
                    return false;
                if (num == length - 1 && freqTable[num] > 1)
                    return false;

                freqTable[num]++;
            }

            return true;

            ////Solution 2
            //var hashSetNums = new HashSet<int>();
            //int maxValue = 0;
            //int freqMax = 0;
            //bool twoFreq = false; 

            //foreach (int num in nums) 
            //{
            //    if (maxValue <= num)
            //    {
            //        if (maxValue < num && !twoFreq)
            //        {
            //            maxValue = num;
            //            freqMax = 1;
            //        }
            //        else if (maxValue == num && freqMax == 1)
            //        {
            //            freqMax = 2;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    if (!hashSetNums.Add(num))
            //    {
            //        if(num != maxValue)
            //        {
            //            return false;
            //        }
            //        if (twoFreq)
            //        {
            //            return false;
            //        }
            //        twoFreq = true;
            //    }
            //}

            //return nums.Length == maxValue+1 ? true : false;
        }
    }
}

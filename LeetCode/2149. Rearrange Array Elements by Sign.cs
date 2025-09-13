using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2149
    {
        ////(2149.) Rearrange Array Elements by Sign (MEDIUM)
        public int[] RearrangeArray(int[] nums)
        {

            //// 5ms, Beats: 58.79%

            int indexPositive = 0;
            int indexNegative = 0;
            int length = nums.Length;
            int[] positiveNums = new int[length/2];
            int[] negativeNums = new int[length/2];

            for (int i = 0; i < length; i++)
            {
                if (nums[i] > 0)
                {
                    positiveNums[indexPositive++] = nums[i];
                }
                else
                {
                    negativeNums[indexNegative++] = nums[i];    
                }
            }

            indexPositive = 0;
            indexNegative = 0;
            for (int i = 0; i < length; i++)
            {
                if(i % 2 == 0)
                {
                    nums[i] = positiveNums[indexPositive++];
                }
                else 
                {
                    nums[i] = negativeNums[indexNegative++];
                }
            }

            return nums;


            //// 9ms, Beats: 32.66%.

            //int[] result = new int[nums.Length];

            //int indexLastPositive = 0;
            //int indexLastNegative = 0;
            //int length = nums.Length;

            //for (int i = 0; i < length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = indexLastPositive; j < length; j++)
            //        {
            //            if (nums[j] > 0)
            //            {
            //                indexLastPositive = j;
            //                break;
            //            }
            //        }
            //        result[i] = nums[indexLastPositive];
            //        indexLastPositive++;
            //    }
            //    else
            //    {
            //        for (int j = indexLastNegative; j < length; j++)
            //        {
            //            if (nums[j] < 0)
            //            {
            //                indexLastNegative = j;
            //                break;
            //            }
            //        }
            //        result[i] = nums[indexLastNegative];
            //        indexLastNegative++;
            //    }
            //}

            //return result;
        }
    }
}

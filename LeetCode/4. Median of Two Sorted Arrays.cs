using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4
    {
        /////(4.) Median of Two Sorted Arrays (HARD)
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combined = nums1.Concat(nums2).ToArray();
            Array.Sort(combined);
            int lengthCombined = combined.Length;

            if (lengthCombined % 2 == 0)
            {
                //Console.WriteLine(combined[(lengthCombined-1) / 2]);
                //Console.WriteLine(combined[(lengthCombined-1) / 2 + 1]);
                return (double)(combined[(lengthCombined - 1) / 2] + combined[(lengthCombined - 1) / 2 + 1]) /2;
            }
            else
            {
                return combined[lengthCombined/2];
            }
        }
    }
}

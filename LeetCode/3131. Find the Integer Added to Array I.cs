using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3131
    {
        ////(3131.) Find the Integer Added to Array I (EASY)
        public int AddedInteger(int[] nums1, int[] nums2)
        {
            ////0ms, Beats: 100.00%

            int sum1 = 0;
            int sum2 = 0;
            int length = nums1.Length;

            for (int i = 0; i < nums1.Length; i++) 
            { 
                sum1 += nums1[i];
                sum2 += nums2[i];
            }

            if(sum1 == sum2)
            {
                return 0;
            }

            return (sum2 - sum1)/length;
        }
    }
}

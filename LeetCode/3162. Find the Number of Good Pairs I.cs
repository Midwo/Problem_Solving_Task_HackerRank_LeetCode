using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3162
    {
        ////(3162.) Find the Number of Good Pairs I (EASY)
        public int NumberOfPairs(int[] nums1, int[] nums2, int k)
        {
            int result = 0;

            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] *= k;

                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums1[j] % nums2[i] == 0)
                    {
                        result++;
                    } 
                }
            }

            return result;            
        }
    }
}

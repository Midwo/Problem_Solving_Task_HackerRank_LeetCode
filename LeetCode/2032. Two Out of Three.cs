using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2032
    {
        ////(2032.) Two Out of Three (EASY)
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            ////Solution #1. 4ms, Beats: 80.49% 
            ////Faster execution and less memory used.

            HashSet<int> result = new HashSet<int>();

            foreach (var item in nums1) 
            { 
                if(nums2.Contains(item) || nums3.Contains(item))
                {
                    result.Add(item);
                }
            }
            foreach (var item in nums2)
            {
                if(nums1.Contains(item) || nums3.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result.ToList();

            ////Solution #2. 8ms, Beats: 56.10%
            #region solution 2 context
            //HashSet<int> result = new HashSet<int>();

            //HashSet<int> distinctListNums1 = new HashSet<int>();
            //HashSet<int> distinctListNums2 = new HashSet<int>();
            //HashSet<int> distinctListNums3 = new HashSet<int>();

            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    distinctListNums1.Add(nums1[i]);
            //}

            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    distinctListNums2.Add(nums2[i]);
            //}

            //for (int i = 0; i < nums3.Length; i++)
            //{
            //    distinctListNums3.Add(nums3[i]);
            //}

            //foreach (int item in distinctListNums2) 
            //{
            //    if (!distinctListNums1.Add(item))
            //    {
            //        result.Add(item);
            //    }
            //}

            //foreach (int item in distinctListNums3)
            //{
            //    if (!distinctListNums1.Add(item))
            //    {
            //        result.Add(item);
            //    }
            //}

            //return result.ToList();
            #endregion
        }
    }
}

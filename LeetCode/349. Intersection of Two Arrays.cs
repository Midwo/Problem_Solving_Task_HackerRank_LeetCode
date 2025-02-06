using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_349
    {
        ////(349.) Intersection of Two Arrays (EASY)
        public int[] Intersection(int[] nums1, int[] nums2)
        {          
            return nums1.Intersect(nums2).ToArray();
        }
    }
}

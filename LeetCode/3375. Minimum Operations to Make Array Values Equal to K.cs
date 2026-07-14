using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3375
    {
        ////(3375.) Minimum Operations to Make Array Values Equal to K (EASY)
        public int MinOperations(int[] nums, int k)
        {
            HashSet<int> distValuesGreaterThanK = new();

            foreach (int num in nums) 
            {
                if (num < k)
                    return -1;
                else if(num > k)
                    distValuesGreaterThanK.Add(num);
            }

            return distValuesGreaterThanK.Count;
        }
    }
}

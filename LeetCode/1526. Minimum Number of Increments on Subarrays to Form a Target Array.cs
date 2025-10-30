using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1526
    {
        ////(1526.) Minimum Number of Increments on Subarrays to Form a Target Array (HARD)
        public int MinNumberOperations(int[] target)
        {
            int count = target[0];
            for (int i = 1; i < target.Length; i++) 
            {
                count += Math.Max(target[i] - target[i - 1], 0);    
            }

            return count;
        }
    }
}

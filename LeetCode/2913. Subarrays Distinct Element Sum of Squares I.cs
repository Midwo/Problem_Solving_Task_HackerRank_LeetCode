using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2913
    {
        ////(2913.) Subarrays Distinct Element Sum of Squares I (EASY)
        public int SumCounts(IList<int> nums)
        {
            int lenght = nums.Count;
            int result = 0;
            for (int indexStart = 0; indexStart < lenght; indexStart++)
            {
                HashSet<int> set = new HashSet<int>();
                for (int currIndex = indexStart; currIndex < lenght; currIndex++)
                {
                    set.Add(nums[currIndex]);
                    result += (int)Math.Pow(set.Count, 2);
                }
            }
            return result; 
        }
    }
}

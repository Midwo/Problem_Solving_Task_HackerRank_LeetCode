using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2357
    {
        ////(2357.) Make Array Zero by Subtracting Equal Amounts (EASY)
        public int MinimumOperations(int[] nums)
        {
            HashSet<int> countUniqueNums = new HashSet<int>();

            foreach (int num in nums)
            {
                if (num > 0)
                {
                    countUniqueNums.Add(num);
                }
            }

            return countUniqueNums.Count;
        }
    }
}

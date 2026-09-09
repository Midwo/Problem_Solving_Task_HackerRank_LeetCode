using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3940
    {
        ////(3940.) Limit Occurrences in Sorted Array (EASY)
        public int[] LimitOccurrences(int[] nums, int k)
        {
            int[] count = new int[101];
            List<int> resultList = new List<int>();

            foreach (var currValue in nums)
            {
                count[currValue]++;
                if (count[currValue] <= k)
                {
                    resultList.Add(currValue);
                }
            }

            return resultList.ToArray();
        }
    }
}

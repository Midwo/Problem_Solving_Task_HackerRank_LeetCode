using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3731
    {
        ////(3731.) Find Missing Elements (EASY)
        public IList<int> FindMissingElements(int[] nums)
        {
            IList<int> result = new List<int>();
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                minValue = minValue > nums[i]? nums[i] : minValue;
                maxValue = maxValue < nums[i]? nums[i] : maxValue;
            }

            for (int i = minValue; i <= maxValue; i++)
            {
                if (!nums.Contains(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1018
    {
        ////(1018.) Binary Prefix Divisible By 5 (EASY)
        public IList<bool> PrefixesDivBy5(int[] nums)
        {
            IList<bool> result = new List<bool>();
            int currValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currValue = (currValue * 2 + nums[i]) % 5;
                result.Add(currValue % 5 == 0);
            }
            return result;
        }
    }
}

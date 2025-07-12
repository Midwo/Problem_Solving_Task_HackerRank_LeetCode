using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1929
    {
        ////(1929.) Concatenation of Array (EASY)
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[nums.Length*2];

            nums.CopyTo(result, 0);
            nums.CopyTo(result, nums.Length);


            return result;
        }
    }
}

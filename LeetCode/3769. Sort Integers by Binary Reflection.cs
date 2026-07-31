using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3769
    {
        ////(3769.) Sort Integers by Binary Reflection (EASY)
        public int[] SortByReflection(int[] nums)
        {
            var result = nums.OrderBy(x => ValueReflection(x)).ThenBy(x => x).ToArray();

            return result;
        }

        private int ValueReflection(int num)
        {
            string stringNum = Convert.ToString(num, 2);
            string stringReflectionNum = new string(stringNum.Reverse().ToArray());
            
            return Convert.ToInt32(stringReflectionNum, 2);
        }
    }
}

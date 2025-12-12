using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3718
    {
        ////(3718.) Smallest Missing Multiple of K (EASY)
        public int MissingMultiple(int[] nums, int k)
        {
            HashSet<int> hashSetNums = new HashSet<int>(nums);

            int currValue = k;
            for (int i = 0; i < nums.Length; i++) 
            { 
                if (!hashSetNums.Contains(currValue))
                {
                    return currValue;
                }
                currValue += k;
            }
            return currValue;
        }
    }
}

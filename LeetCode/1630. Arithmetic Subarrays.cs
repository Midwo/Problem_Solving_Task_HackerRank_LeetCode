using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1630
    {
        ////(1630.) Arithmetic Subarrays (MEDIUM)
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            //// 76ms, Beats: 55.00%

            IList<bool> result = new List<bool>();

            for (int i = 0; i < l.Length; i++)
            {
                int[] tempNums = nums[l[i]..(r[i]+1)];
                Array.Sort(tempNums);
                int diff = tempNums[1] - tempNums[0];
                bool status = true;
                for (int j = 2; j < tempNums.Length; j++)
                {
                    if (diff != tempNums[j] - tempNums[j - 1]) 
                    {
                        status = false;
                        break;
                    }
                }
                result.Add(status);
            }

            return result;
        }
    }
}

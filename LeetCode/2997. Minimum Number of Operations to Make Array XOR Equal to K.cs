using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2997
    {
        ////(2997.) Minimum Number of Operations to Make Array XOR Equal to K (MEDIUM)
        public int MinOperations(int[] nums, int k)
        {
            int allXor = nums[0] ^ k;
            int result = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                allXor ^= nums[i];
            }

            string allXorBinaryWithK = Convert.ToString(allXor, 2);

            for (int i = 0; i < allXorBinaryWithK.Length; i++)
            {
                if (allXorBinaryWithK[i] == '1')
                {
                    result++;
                }
            }


            return result;
        }
    }
}

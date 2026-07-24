using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2917
    {
        ////(2917.) Find the K-or of an Array (EASY)
        public int FindKOr(int[] nums, int k)
        {
            int[] countBitsPositions = new int[32];

            foreach (int num in nums) 
            {
                string binaryNum = Convert.ToString(num, 2);
                int startIndex = binaryNum.Length - 1;
                int indexCountBitsPositions = 0;
                
                while(startIndex >= 0)
                {
                    if (binaryNum[startIndex--] == '1')
                        countBitsPositions[indexCountBitsPositions]++;
                    indexCountBitsPositions++;
                }
            }

            int pow = 0;
            int result = 0;

            for(int index = 0; index < 32; index++)
            {
                if (countBitsPositions[index] >= k)
                {
                    result += (int)Math.Pow(2, pow);
                }
                pow++;
            }

            return result;
        }
    }
}

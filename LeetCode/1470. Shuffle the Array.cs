using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1470
    {
        ////(1470.) Shuffle the Array (EASY)
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            int index = n;
            int indexInsert = 0;

            for (int i = 0; i < n; i++)
            {
                result[indexInsert] = nums[i];
                result[indexInsert + 1] = nums[index];
                indexInsert += 2;
                index++;
            }

            return result;
        }
    }
}

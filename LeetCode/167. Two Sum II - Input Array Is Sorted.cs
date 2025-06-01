using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_167
    {
        ////(167.) Two Sum II - Input Array Is Sorted (MEDIUM)
        public int[] TwoSum(int[] numbers, int target)
        {
            bool end = false;
            int L = 0;
            int R = numbers.Length-1;
            while (!end)
            {
                if (numbers[L] + numbers[R] < target)
                {
                    L++;
                }
                else if (numbers[L] + numbers[R] > target)
                {
                    R--;
                }
                else if (numbers[L] + numbers[R] == target)
                {
                    return new int[] { L+1, R+1 };
                }
            }

            return numbers;
        }
    }
}

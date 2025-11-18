using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3550
    {
        ////(3550.) Smallest Index With Digit Sum Equal to Index (EASY)
        public int SmallestIndex(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (temp > 9)
                {
                    int sum = 0;

                    while(temp != 0)
                    {
                        int moduloRest = temp % 10;
                        sum += moduloRest;
                        temp /= 10;
                    }
                    if (sum == i)
                    {
                        return i;
                    }
                }
                else if (nums[i] == i)
                {
                    return i;
                }

            }

            return -1;
        }
    }
}

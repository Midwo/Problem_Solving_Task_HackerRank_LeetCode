using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3471
    {
        ////(3471.) Find the Largest Almost Missing Integer (EASY)
        public int LargestInteger(int[] nums, int k)
        {
            int[] countNumbers = new int[51];
            int length = nums.Length;

            for (int i = 0; i <= length - k; i++)
            {
                HashSet<int> numbers = new HashSet<int>();
                numbers.Add(nums[i]);
                for (int j = i + 1; j < i+k; j++)
                {
                    numbers.Add(nums[j]);
                }

                foreach (int n in numbers)
                {
                    countNumbers[n]++;
                }
            }

            int largestInteger = -1;

            for (int i = 0; i < 51; i++)
            {
                if (countNumbers[i] == 1) 
                {
                    largestInteger = i;
                }
            }

            return largestInteger;
        }
    }
}

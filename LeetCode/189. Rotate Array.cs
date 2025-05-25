using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_189
    {
        ////(189.) Rotate Array (MEDIUM)
        public void Rotate(int[] nums, int k)
        {
            //[1, 2, 3, 4, 5, 6, 7], k = 3
            int length = nums.Length;
            k = k % length;
            int[] dummyNums = nums.ToArray();

            ////Only for test
            Console.WriteLine(string.Join(',', nums));

            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine(i);
                int tempValue = dummyNums[i];
                if (i+k >= length)
                {
                    nums[(i + k) % length] = tempValue;
                }
                else
                {
                    //nums[i] = nums[i+k];
                    nums[i+k] = tempValue;
                }
            }

            ////Only for test
            Console.WriteLine(string.Join(',', nums));
        }
    }
}

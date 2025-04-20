using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_922
    {
        //(922.) Sort Array By Parity II (EASY)
        public int[] SortArrayByParityII(int[] nums)
        {
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nums[i]);
                Console.WriteLine(i);

                int currNum = nums[i];
                if (i % 2 == 0)
                {
                    if (currNum % 2 != 0)
                    {
                        for (int j = length-1; j >= 0; j--)
                        {
                            int currNewNum = nums[j];
                            if (currNewNum % 2 == 0)
                            {
                                nums[i] = currNewNum;
                                nums[j] = currNum;
                                break;
                            }
                            //Console.WriteLine(nums[j]);
                            //Console.WriteLine(j);
                        }
                    }
                }
                else
                {
                    if (currNum % 2 == 0)
                    {
                        for (int j = length - 1; j >= 0; j--)
                        {
                            int currNewNum = nums[j];
                            //Console.WriteLine(nums[j]);
                            //Console.WriteLine(j);
                            if (currNewNum % 2 != 0)
                            {
                                nums[i] = currNewNum;
                                nums[j] = currNum;
                                break;
                            }
                        }
                    }
                }
            }
            return nums;
        }
    }
}

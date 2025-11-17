using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3452
    {
        ////(3452.) Sum of Good Numbers (EASY)
        public int SumOfGoodNumbers(int[] nums, int k)
        {
            int resultSum = 0;
            int length = nums.Length;

            for (int i = 0; i < length; i++) 
            { 
                int temp = nums[i];
                if(i-k < 0)
                {
                    if (i+k < length)
                    {
                        if(temp > nums[i + k])
                        {
                            resultSum += temp;
                        }
                    }
                    else
                    {
                        resultSum += temp;
                    }
                }
                else
                {
                    if(i+k < length)
                    {
                        if(temp > nums[i+k] && temp > nums[i - k])
                        {
                            resultSum += temp;
                        }
                    }
                    else
                    {
                        if (temp > nums[i - k]) 
                        {
                            resultSum += temp;
                        }
                    }
                }
            }

            return resultSum;
        }
    }
}

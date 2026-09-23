using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1658
    {
        ////(1658.) Minimum Operations to Reduce X to Zero (MEDIUM)
        public int MinOperations(int[] nums, int x)
        {
            int length = nums.Length;
            int[] rightSumTable = new int[length];
            int currSum = 0;
            int minIndexRight = 0;
            int minOperations = int.MaxValue;

            for (int index = length-1; index >= 0; index--)
            {
                currSum += nums[index];
                if (currSum < 0)
                {
                    minIndexRight = index;
                    break;
                }
                else if (currSum == x)
                {
                    minIndexRight = index;
                    minOperations = length - index;
                    break;
                }
                else if (currSum > x)
                {
                    minIndexRight = index+1;
                    break;
                }
                rightSumTable[index] = currSum;
            }

            currSum = 0;
            for (int index = 0; index < length; index++) 
            {
                currSum += nums[index];
                if(currSum > x || currSum < 0)
                {
                    break;
                }
                else if(currSum == x)
                {
                    minOperations = Math.Min(minOperations, index + 1);
                    break;
                }
                else if(minOperations < index + 1)
                {
                    break;
                }

                
                if(minIndexRight <= index)
                {
                    minIndexRight = index + 1;
                }

                while(minIndexRight < length)
                {
                    int newSum = rightSumTable[minIndexRight] + currSum;
                    if(newSum < 0)
                    {
                        break;
                    }
                    else if (newSum > x)
                    {
                        minIndexRight++;
                    }
                    else if (newSum == x)
                    {
                        minOperations = Math.Min(minOperations, index + 1 + length - minIndexRight);
                        break;
                    }
                    else if (newSum < x)
                    {
                        break;
                    }
                }
            }
            return minOperations == int.MaxValue ? -1: minOperations;
        }
    }
}

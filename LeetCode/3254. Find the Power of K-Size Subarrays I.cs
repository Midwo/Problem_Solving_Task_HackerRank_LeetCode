using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3254
    {
        ////(3254.) Find the Power of K-Size Subarrays I (MEDIUM)
        public int[] ResultsArray(int[] nums, int k)
        {
            int length = nums.Length;
            int[] resultTable = new int[length-k+1];
            bool statusCorrect = false;

            if (k == 1)
            {
                return nums;
            }

            for (int i = 0; i < length-k+1; i++) 
            {
                if (statusCorrect)
                {
                    if(nums[i+k-2]+1 == nums[i + k - 1])
                    {
                        resultTable[i] = nums[i + k - 1];
                    }
                    else
                    {
                        statusCorrect = false;
                        resultTable[i] = -1;
                    }
                }
                else
                {
                    bool statusGrow = true;
                    int lastValue = nums[i];
                    int currValue = 0;
                    for (int j = i+1; j < i+k; j++)
                    {
                        currValue = nums[j];
                        if(currValue != lastValue+1)
                        {
                            statusGrow = false;
                            break;
                        }
                        lastValue = currValue;
                    }
                    if (statusGrow)
                    {
                        statusCorrect = true;
                        resultTable[i] = currValue;
                    }
                    else
                    {
                        resultTable[i] = -1;
                    }
                }
            }

            return resultTable;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1248
    {
        ////(1248.) Count Number of Nice Subarrays (MEDIUM)
        public int NumberOfSubarrays(int[] nums, int k)
        {
            int countNiceSubarrays = 0;
            Queue<int> oddWindowIndex = new Queue<int>();
            int index = 0;
            int length = nums.Length;
            int newWindowIndexStart = 0;

            while (length > index) 
            {
                int currValue = nums[index];
                
                if(currValue % 2 == 1)
                {
                    oddWindowIndex.Enqueue(index);
                }

                if(oddWindowIndex.Count == k)
                {
                    int countNoAdd = 0;
                    index++;
                    while(index < length)
                    {
                        int tempValue = nums[index];
                        if(tempValue % 2 == 0)
                        {
                            countNoAdd++;
                        }
                        else
                        {
                            break;
                        }
                        index++;
                    }
                    int lastOdd = oddWindowIndex.Dequeue();

                    countNiceSubarrays += (countNoAdd+1) * (lastOdd - newWindowIndexStart + 1);

                    newWindowIndexStart = lastOdd+1;
                }
                else
                {
                    index++;
                }

            }
            return countNiceSubarrays;
        }
    }
}

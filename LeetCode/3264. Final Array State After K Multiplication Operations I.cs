using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3264
    {
        ////(3264.) Final Array State After K Multiplication Operations I (EASY)
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                priorityQueue.Enqueue(nums[i], nums[i]);
            }

            for (int i = 0; i < k; i++)
            {
                int temp = priorityQueue.Dequeue();
                int newValue = temp * multiplier;
                priorityQueue.Enqueue(newValue, newValue);    
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == temp)
                    {
                        nums[j] = newValue;
                        break;
                    }
                }
            }

            return nums;
        }
    }
}

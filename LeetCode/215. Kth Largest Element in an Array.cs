using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_215
    {
        ////(215.) Kth Largest Element in an Array (MEDIUM)
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> priorityQueueList = new PriorityQueue<int, int>();
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                priorityQueueList.Enqueue(nums[i], -nums[i]);
            }

            for (int i = 1; i < k; i++)
            {
                priorityQueueList.Dequeue();
            }

            return priorityQueueList.Peek();
        }
    }
}

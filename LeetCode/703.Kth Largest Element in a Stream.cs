using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_703
    {
        //703. Kth Largest Element in a Stream (EASY)
        public class KthLargest
        {
            private int k { get; set; }
            private PriorityQueue<int, int> priorityQueue { get; set; }

            public KthLargest(int k, int[] nums)
            {
                this.k = k;
                priorityQueue = new PriorityQueue<int, int>();

                foreach (var num in nums)
                {
                    Add(num);
                }
            }

            public int Add(int val)
            {
                priorityQueue.Enqueue(val, val);

                while (priorityQueue.Count > this.k)
                {
                    priorityQueue.Dequeue();
                }

                return priorityQueue.Peek();
            }
        } 
    }
}

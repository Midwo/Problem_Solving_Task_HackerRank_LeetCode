using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2160
    {
        ////(2160.) Minimum Sum of Four Digit Number After Splitting Digits (EASY) 
        public int MinimumSum(int num)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            while (num != 0)
            {
                int temp = num % 10;
                priorityQueue.Enqueue(temp, temp);
                num /= 10;
            }

            int result = 0;
            result += priorityQueue.Dequeue() * 10;
            result += priorityQueue.Dequeue() * 10;
            result += priorityQueue.Dequeue();
            result += priorityQueue.Dequeue();

            return result;
        }
    }
}

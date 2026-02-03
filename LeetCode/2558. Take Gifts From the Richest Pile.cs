using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2558
    {
        ////(2558.) Take Gifts From the Richest Pile (EASY)
        public long PickGifts(int[] gifts, int k)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

            long result = 0;

            for (int i = 0; i < gifts.Length; i++)
            {
                priorityQueue.Enqueue(gifts[i], gifts[i]);
            }
            
            for (int i = 0; i < k; i++)
            {
                int temp = priorityQueue.Dequeue();
                int sqrtValue = (int)Math.Sqrt(temp);
                priorityQueue.Enqueue(sqrtValue, sqrtValue);
            }

            while (priorityQueue.Count > 0)
            {
                result += priorityQueue.Dequeue();
            }

            return result;
        }
    }
}

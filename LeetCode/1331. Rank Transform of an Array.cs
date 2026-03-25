using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1331
    {
        ////(1331.) Rank Transform of an Array (EASY)
        public int[] ArrayRankTransform(int[] arr)
        {
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                priorityQueue.Enqueue(i, arr[i]);
            }

            int[] newArr = new int[arr.Length];
            int index = 1;
            int lastValue = int.MinValue;
            while (priorityQueue.Count != 0)
            {
                int temp = priorityQueue.Dequeue();

                if (lastValue == arr[temp])
                {
                    newArr[temp] = index - 1;
                }
                else
                {
                    newArr[temp] = index++;
                    lastValue = arr[temp];
                }
            }
            return newArr;
        }
    }
}


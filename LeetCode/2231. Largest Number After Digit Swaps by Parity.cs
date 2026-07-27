using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2231
    {
        ////(2231.) Largest Number After Digit Swaps by Parity (EASY)
        public int LargestInteger(int num)
        {
            int copyNum = num;
            PriorityQueue<int, int> priorityQueueEven = new PriorityQueue<int, int>();
            PriorityQueue<int, int> priorityQueueOdd = new PriorityQueue<int, int>();

            while(copyNum != 0)
            {
                int currValue = copyNum % 10;
                if (currValue % 2 == 0)
                    priorityQueueEven.Enqueue(currValue, currValue);
                else
                    priorityQueueOdd.Enqueue(currValue, currValue);
                copyNum /= 10;
            }

            int multipier = 1;
            int resultValue = 0;

            copyNum = num;
            while (copyNum != 0)
            {
                int currValue = copyNum % 10;
                if (currValue % 2 == 0)
                    resultValue += priorityQueueEven.Dequeue() * multipier;
                else
                    resultValue += priorityQueueOdd.Dequeue() * multipier;
                multipier *= 10;
                copyNum /= 10;
            }

            return resultValue;
        }
    }
}

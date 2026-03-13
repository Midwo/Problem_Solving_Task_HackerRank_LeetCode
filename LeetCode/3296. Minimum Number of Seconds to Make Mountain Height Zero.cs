using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3296
    {
        ////(3296.) Minimum Number of Seconds to Make Mountain Height Zero (MEDIUM)
        public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
        {
            long maxTime = 0;
            int lengthWorker = workerTimes.Length;
            PriorityQueue<int, long> priorityQueue = new PriorityQueue<int, long>();
            long[,] workerTimesAndCount = new long[lengthWorker,2];

            for (int i = 0; i < workerTimes.Length; i++)
            {
                priorityQueue.Enqueue(i, workerTimes[i]);
                workerTimesAndCount[i, 0] = workerTimes[i];
                workerTimesAndCount[i, 1] = 1;
            }

            for (int i = 0; i < mountainHeight; i++)
            {
                priorityQueue.TryDequeue(out int element, out long priority);
                maxTime = maxTime < priority ? priority : maxTime;
                workerTimesAndCount[element, 1]++;
                priorityQueue.Enqueue(element, priority + workerTimesAndCount[element, 0] * workerTimesAndCount[element,1]);                
            }

            return maxTime;
        }
    }
}

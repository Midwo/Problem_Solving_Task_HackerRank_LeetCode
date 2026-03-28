using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2895
    {
        ////(2895.) Minimum Processing Time (MEDIUM)
        public int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            int maxTime = 0;

            int[] processorTimeSortArray = processorTime.ToArray();
            Array.Sort(processorTimeSortArray);

            int[] tasksSortArray = tasks.ToArray();
            Array.Sort(tasksSortArray, (a, b) => (b - a));

            int lengthProcessorTime = processorTimeSortArray.Length;
            int lengthTasks = tasksSortArray.Length;

            int indexTasks = 0;

            for (int indexProcessorTime = 0; indexProcessorTime < lengthProcessorTime; indexProcessorTime++)
            {
                maxTime = Math.Max(maxTime, processorTimeSortArray[indexProcessorTime] + tasksSortArray[indexTasks]);
                indexTasks += 4;
            }

            return maxTime;
        }
    }
}

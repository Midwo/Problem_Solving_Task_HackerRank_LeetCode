using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2530
    {
        ////(2530.) Maximal Score After Applying K Operations (MEDIUM)
        public long MaxKelements(int[] nums, int k)
        {
            long result = 0;

            PriorityQueue<int, int> prioprityQueueMaxFirst = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            foreach (int x in nums)
            {
                prioprityQueueMaxFirst.Enqueue(x, x);
            }

            for (int i = 0; i < k; i++)
            {
                int currValue = prioprityQueueMaxFirst.Dequeue();
                int ceilValue = currValue / 3;
                if (currValue % 3 > 0)
                    ceilValue += 1;
                prioprityQueueMaxFirst.Enqueue(ceilValue, ceilValue);
                result += currValue;
            }

            return result;
        }
    }
}

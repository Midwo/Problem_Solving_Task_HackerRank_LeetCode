using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1356
    {
        ////(1356.) Sort Integers by The Number of 1 Bits (EASY)
        public int[] SortByBits(int[] arr)
        {
            var sorted = arr.Select((x, i) => new { Value = x, Index = i })
                            .OrderBy(item => countBits(item.Value))
                            .ThenBy(item => item.Value)
                            .Select(item => item.Value)
                            .ToArray();
            return sorted;
        }
        static int countBits(int valueArr)
        {
            int count = 0;
            while (valueArr != 0)
            {
                if ((valueArr & 1) == 1)
                    count += 1;
                valueArr = valueArr / 2;
            }
            return count;
        }
    }
}

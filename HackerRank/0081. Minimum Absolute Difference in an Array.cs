using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0081
    {
        ////81. Minimum Absolute Difference in an Array (EASY)
        public int minimumAbsoluteDifference(List<int> arr)
        {
            int minAbsValue = int.MaxValue;

            arr.Sort();

            for (int i = 1; i < arr.Count; i++)
            {
                int absValue = Math.Abs(arr[i] - arr[i - 1]);
                if (minAbsValue > absValue)
                {
                    minAbsValue = absValue;
                }
            }
            return minAbsValue;
        }
    }
}

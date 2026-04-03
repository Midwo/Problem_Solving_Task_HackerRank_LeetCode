using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0025
    {
        public int maxMin(int k, List<int> arr)
        {
            k--;
            arr.Sort();
            int minValue = int.MaxValue;
            int actualValue = 0;
            for (int i = 0; i < arr.Count - k; i++)
            {
                actualValue = arr[i + k] - arr[i];
                if (actualValue < minValue)
                {
                    minValue = actualValue;
                }
            }
            return minValue;
        }

    }
}

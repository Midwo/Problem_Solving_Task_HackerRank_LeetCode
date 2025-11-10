using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2951
    {
        ////(2951.) Find the Peaks (EASY)
        public IList<int> FindPeaks(int[] mountain)
        {
            IList<int> result = new List<int>();

            for (int i = 1; i < mountain.Length-1; i++)
            {
                if (mountain[i] > mountain[i-1] && mountain[i] > mountain[i + 1])
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}

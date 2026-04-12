using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0070
    {
        ////70. Permuting Two Arrays (EASY)
        public string twoArrays(int k, List<int> A, List<int> B)
        {
            A.Sort();
            B = B.OrderBy(x => x).Reverse().ToList();
            bool trueOrFalse = false;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] + B[i] < k)
                {
                    return "NO";
                }
            }
            return "YES";
        }
    }
}


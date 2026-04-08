using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0029
    {
        ////29. Compare the Triplets (EASY)
        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            int Alice = 0;
            int Bob = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    Alice++;
                }
                else if (a[i] < b[i])
                {
                    Bob++;
                }
            }
            List<int> results = [Alice, Bob];
            return results;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0020
    {
        public int beautifulPairs(List<int> A, List<int> B)
        {
            int pairs = 0;
            int countA = A.Count;
            for (int i = 0; i < A.Count; i++)
            {
                for (int y = 0; y < B.Count; y++)
                {
                    if (A[i] == B[y])
                    {
                        pairs++;
                        A.RemoveAt(i);
                        B.RemoveAt(y);
                        i = -1;
                        break;
                    }
                }
            }
            if (pairs != countA)
            {
                pairs++;
            }
            else
            {
                pairs--;
            }
            return pairs;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0076
    {
        ////76. Beautiful Pairs (EASY)
        public int beautifulPairs(List<int> A, List<int> B)
        {
            Dictionary<int, int> dictB = new Dictionary<int, int>();
            int countBeautifulPairs = 0;
            bool addOne = false;
            foreach (int i in B) 
            {
                if (dictB.ContainsKey(i))
                {
                    dictB[i]++;
                }
                else
                {
                    dictB.Add(i, 1);
                }
            }

            for (int index = 0; index < A.Count; index++)
            {
                int currValue = A[index];

                if (dictB.ContainsKey(currValue) && dictB[currValue] > 0)
                {
                    countBeautifulPairs++;
                    dictB[currValue]--;
                }
                else
                {
                    addOne = true;
                }

            }

            if (addOne)
            {
                return countBeautifulPairs+1;
            }
            else
            {
                return countBeautifulPairs - 1;
            }

        }
    }
}

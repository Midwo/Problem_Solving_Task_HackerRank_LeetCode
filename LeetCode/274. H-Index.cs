using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_274
    {
        ////(274.) H-Index (MEDIUM)
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            int count = 0;
            int publication = 1;
            for (int i = citations.Length; i > 0; i--)
            {
                if (citations[i - 1] >= publication)
                {
                    publication++;
                    count++;
                }
                else
                {
                    return count;
                }
            }

            return publication - 1;
        }
    }
}

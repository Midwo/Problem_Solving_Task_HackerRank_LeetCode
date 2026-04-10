using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0054
    {
        ////54. Circular Array Rotation (EASY)
        public List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            List<int> queries1 = new List<int>();
            int length = a.Count;
            int remainder = k % length;

            for (int i = 0; i < queries.Count; i++)
            {
                int indexSeachr = (length - (remainder - queries[i])) % length;
                // Console.WriteLine(x);
                queries1.Add(a[indexSeachr]);
            }
            return queries1;
        }
    }
}

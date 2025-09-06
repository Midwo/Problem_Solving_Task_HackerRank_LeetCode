using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1409
    {
        ////(1409.) Queries on a Permutation With Key (MEDIUM)
        public int[] ProcessQueries(int[] queries, int m)
        {
            List<int> permutationM = new List<int>();

            for (int i = 1; i <= m; i++)
            {
                permutationM.Add(i);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int temp = permutationM.IndexOf(queries[i]);
                permutationM.RemoveAt(temp);
                permutationM.Insert(0, queries[i]);
                queries[i] = temp;
            }

            return queries;
        }
    }
}

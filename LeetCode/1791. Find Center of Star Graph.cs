using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1791
    {
        ////(1791.) Find Center of Star Graph (EASY)
        public int FindCenter(int[][] edges)
        {
            if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
            {
                return edges[0][0];
            }

            if (edges[0][1] == edges[1][0] || edges[0][1] == edges[1][1])
            {
                return edges[0][1];
            }

            return 0;


            //// Another solution, worse:

            //Dictionary<int, int> countEdgesValue = new Dictionary<int, int>();

            //for (int i = 0; i < edges.Length; i++)
            //{
            //    if (countEdgesValue.ContainsKey(edges[i][0]))
            //    {
            //        countEdgesValue[edges[i][0]]++;
            //    }
            //    else
            //    {
            //        countEdgesValue.Add(edges[i][0], 1);
            //    }

            //    if (countEdgesValue.ContainsKey(edges[i][1]))
            //    {
            //        countEdgesValue[edges[i][1]]++;
            //    }
            //    else
            //    {
            //        countEdgesValue.Add(edges[i][1], 1);
            //    }
            //}

            //int maxCount = 0;
            //int result = 0;

            //foreach (var item in countEdgesValue)
            //{
            //    if (maxCount < item.Value)
            //    {
            //        maxCount = item.Value;
            //        result = item.Key;
            //    }
            //}

            //return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1828
    {
        ////(1828.) Queries on Number of Points Inside a Circle (MEDIUM)
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < points.Length; j++)
                {
                    double euclideanDistance = Math.Sqrt(Math.Pow((queries[i][0] - points[j][0]), 2) + Math.Pow((queries[i][1] - points[j][1]),2));
                    if (euclideanDistance < queries[i][2])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }
    }
}

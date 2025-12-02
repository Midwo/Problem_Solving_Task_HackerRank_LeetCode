using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_973
    {
        ////(973.) K Closest Points to Origin (MEDIUM)
        public int[][] KClosest(int[][] points, int k)
        {
            int[][] distancePoints = new int[points.Length][];
            int minimumDistance = int.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                int temp = points[i][0]*points[i][0]+points[i][1]*points[i][1];
                distancePoints[i] = new int[] {temp, i};
            }

            List<int[]> listResult = new List<int[]>();

            distancePoints = distancePoints.OrderBy(x => x[0]).ToArray();

            for (int i = 0; i < k; i++) 
            { 
                listResult.Add(points[distancePoints[i][1]]);
            }

            return listResult.ToArray();
        }
    }
}

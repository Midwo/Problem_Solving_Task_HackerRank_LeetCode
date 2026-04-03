using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0014
    {
        public int flatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int maxDistanceFromStation = c[0];
            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                maxDistanceFromStation = Math.Max(maxDistanceFromStation, distance);
            }
            return Math.Max(maxDistanceFromStation, n - 1 - c[c.Length - 1]);
        }

    }
}

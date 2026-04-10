using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0056
    {
        ////56. Jumping on the Clouds: Revisited (EASY)
        public int jumpingOnClouds(int[] c, int k)
        {
            int index = 0;
            int points = 100;

            while (true)
            {
                index += k;
                if (index > c.Length - 1)
                {
                    index = index % c.Length;
                }

                if (c[index] == 1)
                    points -= 2;

                points--;
                if (index == 0) break;
            }
            return points;
        }
    }
}

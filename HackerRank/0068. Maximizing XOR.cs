using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0068
    {
        ////68. Maximizing XOR (EASY)       
        public int maximizingXor(int l, int r)
        {
            int max = 0;
            for (int i = l; i <= r; i++)
            {
                for (int j = i + 1; j <= r; j++)
                {
                    int xor = (i ^ j);
                    if (xor > max)
                    {
                        max = xor;
                    }
                }
            }
            return max;
        }
    }
}

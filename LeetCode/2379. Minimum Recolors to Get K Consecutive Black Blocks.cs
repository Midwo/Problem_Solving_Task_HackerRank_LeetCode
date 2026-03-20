using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2379
    {
        ////(2379.) Minimum Recolors to Get K Consecutive Black Blocks (EASY)
        public int MinimumRecolors(string blocks, int k)
        {
            int minWhite = 0;
            int currCountW = 0;

            for (int i = 0; i < k; i++)
            {
                if (blocks[i] == 'W')
                {
                    currCountW++;
                }
            }

            minWhite = currCountW;

            for (int i = k; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W')
                {
                    currCountW++;
                }
                if (blocks[i-k] == 'W')
                {
                    currCountW--;
                }
                minWhite = Math.Min(minWhite, currCountW);
            }

            return minWhite;
        }
    }
}

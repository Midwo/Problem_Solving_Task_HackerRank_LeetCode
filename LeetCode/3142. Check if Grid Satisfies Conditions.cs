using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3142
    {
        ////(3142.) Check if Grid Satisfies Conditions (EASY)
        public bool SatisfiesConditions(int[][] grid)
        {
            int lastValueCol = int.MinValue;
            int countRow = grid.Length;
            int countCol = grid[0].Length;

            for (int i = 0; i < countCol; i++) 
            {
                int currValueCol = grid[0][i];
                
                if (lastValueCol == currValueCol)
                {
                    return false;
                }

                for (int j = 1; j < countRow; j++)
                {
                    if (grid[j][i] != currValueCol)
                    {
                        return false;
                    }
                }

                lastValueCol = currValueCol;
            }

            return true;
        }
    }
}

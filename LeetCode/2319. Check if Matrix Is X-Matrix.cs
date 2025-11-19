using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2319
    {
        ////(2319.) Check if Matrix Is X-Matrix (EASY)
        public bool CheckXMatrix(int[][] grid)
        {
            int length = grid.Length;
            int numberCheck = 0;
                for (int i = 0; i < length; i++)
                {
                    for(int j = 0; j< length; j++)
                    {
                        if(j == numberCheck || j == length - 1 - numberCheck)
                        {
                            if (grid[i][j] == 0)
                            {
                                return false;
                            }
                        }
                        else if (grid[i][j] > 0)
                        {
                            return false;
                        }
                    }
                    numberCheck++;
                }

            return true;
        }
    }
}

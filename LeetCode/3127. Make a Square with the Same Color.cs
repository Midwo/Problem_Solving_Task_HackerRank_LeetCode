using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3127
    {
        ////(3127.) Make a Square with the Same Color (EASY)
        public bool CanMakeSquare(char[][] grid)
        {
            for (int col = 1; col < 3; col++)
            {
                for(int row = 1; row < 3; row++)
                {
                    int diff = 
                        (grid[row][col] == 'B' ? 1 : -1) + 
                        (grid[row][col-1] == 'B' ? 1 : -1) + 
                        (grid[row - 1][col] == 'B' ? 1 : -1) + 
                        (grid[row - 1][col - 1] == 'B' ? 1 : -1);

                    if ((diff = diff < 0 ? -diff : diff) >= 2)
                        return true;
                    //OR
                    //if ((diff < 0 ? -diff : diff) >= 2)
                    //    return true;
                    //OR
                    //if (Math.Abs(diff) >= 2)
                    //    return true;
                }
            }

            return false;
        }
    }
}



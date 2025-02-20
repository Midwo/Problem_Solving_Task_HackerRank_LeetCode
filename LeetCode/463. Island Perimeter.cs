using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_463
    {
        ////(463.) Island Perimeter (EASY)
        public int IslandPerimeter(int[][] grid)
        {
            int result = 0;
            int prevLevelCountNumber = 0;
            bool clearBox = true;
            int numberOfLevels = grid.Count();
            for (int i = 0; i <numberOfLevels; i++)
            {
                clearBox = true;
                if (i == 0)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            result += 4;
                            if (clearBox == false)
                            {
                                result -= 2;
                            }
                            clearBox = false;
                        }
                        else
                        {
                            clearBox = true;
                        }
                    } 
                }
                else
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            if (prevLevelCountNumber >= j)
                            {
                                if (grid[i - 1][j] == 1)
                                {
                                    result -= 2;
                                }
                            }
                            result += 4;
                            if (clearBox == false)
                            {
                                result -= 2;
                            }
                            clearBox = false;
                        }
                        else
                        {
                            clearBox = true;
                        }
                    }
                }
                prevLevelCountNumber = grid[i].Length;
            }
            return result;  
        }
    }
}

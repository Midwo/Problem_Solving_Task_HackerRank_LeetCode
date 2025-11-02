using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2257
    {
        ////(2257.) Count Unguarded Cells in the Grid (MEDIUM)
        public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            int[][] testGrid = new int[m][];
            int lengthWalls = walls.Length;
            int lengthGurads = guards.Length;
            int result = 0;
            
            for (int i = 0; i < m; i++)
            {
                testGrid[i] = new int[n];
            }
            
            ////number 2 is wall/guard
            for (int i = 0; i < lengthWalls; i++)
            {
                testGrid[walls[i][0]][walls[i][1]] = 2;
            }

            ////number 2 is wall/guard
            for (int i = 0; i < lengthGurads; i++)
            {
                testGrid[guards[i][0]][guards[i][1]] = 2;
            }

            ////number 1 is guarded
            for (int i = 0; i < lengthGurads; i++)
            {
                int y = guards[i][0];
                int x = guards[i][1];

                if (y > 0)
                {
                    for (int j = y - 1; j >= 0; j--)
                    {
                        if (testGrid[j][x] == 0)
                        {
                            testGrid[j][x] = 1;
                        }
                        else if (testGrid[j][x] == 2)
                        {
                            break;
                        }
                    }
                }
                
                if(y < m - 1)
                {
                    for (int j = y+1; j < m; j++)
                    {
                        if (testGrid[j][x] == 0)
                        {
                            testGrid[j][x] = 1;
                        }
                        else if (testGrid[j][x] == 2)
                        {
                            break;
                        }
                    }
                }

                if (x > 0)
                {
                    for (int j = x - 1; j >= 0; j--)
                    {
                        if (testGrid[y][j] == 0)
                        {
                            testGrid[y][j] = 1;
                        }
                        else if (testGrid[y][j] == 2)
                        {
                            break;
                        }
                    }
                }

                if (x < n - 1)
                {
                    for (int j = x + 1; j < n; j++)
                    {
                        if (testGrid[y][j] == 0)
                        {
                            testGrid[y][j] = 1;
                        }
                        else if (testGrid[y][j] == 2)
                        {
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (testGrid[i][j] == 0)
                    {
                        result++;
                    }
                }
            }


            return result;
        }
    }
}

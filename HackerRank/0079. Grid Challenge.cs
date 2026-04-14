using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0079
    {
        ////79. Grid Challenge (EASY)
        public string gridChallenge(List<string> grid)
        {
            int rows = grid.Count;
            int cols = grid[0].Length;
            char[][] charGrid = new char[rows][];
            
            for (int i = 0; i < rows; i++)
            {
                //charGrid[i] = grid[i].ToArray().OrderBy(x => x).ToArray();

                //Better this:
                char[] temp = grid[i].ToCharArray();
                Array.Sort(temp);
                charGrid[i] = temp;
            }

            for (int indexCol = 0; indexCol < cols; indexCol++) 
            {
                int lastChar = charGrid[0][indexCol];

                for (int indexRow = 1; indexRow < rows; indexRow++)
                {
                    int currChar = charGrid[indexRow][indexCol];

                    if(lastChar > currChar)
                    {
                        return "NO";
                    }
                    lastChar = currChar;
                }            
            }

            return "YES";

            ////Old version -> Much worse. Less efficient.

            //bool endLoop = false;
            //string outprint = string.Empty;
            //if (grid.Count > 1)
            //{
            //    for (int i = 0; i < grid.Count; i++)
            //    {
            //        grid[i] = String.Concat(grid[i].OrderBy(c => c));
            //    }

            //    int howLengh = grid[0].Length;

            //    for (int i = 0; i < howLengh; i++)
            //    {
            //        if (endLoop == false)
            //        {
            //            for (int x = 1; x < grid.Count; x++)
            //            {
            //                if ((int)Convert.ToChar(grid[x - 1][i]) <= (int)Convert.ToChar(grid[x][i]))
            //                {
            //                    outprint = "YES";
            //                }
            //                else
            //                {
            //                    outprint = "NO";
            //                    endLoop = true;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    outprint = "YES";
            //}
            //return outprint;
        }
    }
}

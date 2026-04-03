using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0008
    {
        public List<string> Cavity_Map(List<string> grid)
        {
            //grid = ["1112", "1912", "1892", "1234"];
            int lenghtStringInGrid = grid[0].Length;
            int countGridMinusOne = grid.Count - 1;
            List<string> newGrid = new List<string>();
            newGrid = grid.ToList();

            for (int i = 1; i < lenghtStringInGrid - 1; i++)
            {
                for (int x = 1; x < countGridMinusOne; x++)
                {
                    int actualRecordValue = Int32.Parse(grid[x][i].ToString());
                    if (actualRecordValue > Int32.Parse(grid[x - 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x + 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i - 1].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i + 1].ToString()))
                    {
                        newGrid[x] = newGrid[x].Substring(0, i) + "X" + newGrid[x].Substring(i + 1);
                    }
                }
            }
            return newGrid;
        }

    }
}

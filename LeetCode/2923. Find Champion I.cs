using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2923
    {
        ////(2923.) Find Champion I (EASY)
        public int FindChampion(int[][] grid)
        {
            int championIndex = -1;
            int maxSumChampionPoints = -1;
            int maxPoints = grid[0].Length;

            for (int i = 0; i < grid.Length; i++)
            {
                int currSumPoints = 0;
                for (int j = 0; j < maxPoints; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        currSumPoints++;
                    }
                }
                if (maxSumChampionPoints < currSumPoints)
                {
                    maxSumChampionPoints = currSumPoints;
                    championIndex = i;
                    if(maxPoints == maxSumChampionPoints)
                    {
                        return i;
                    }
                }
            }

            return championIndex;
        }
    }
}

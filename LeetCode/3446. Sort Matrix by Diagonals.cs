using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3446
    {
        ////3446. Sort Matrix by Diagonals (MEDIUM)
        public int[][] SortMatrix(int[][] grid)
        {
            int length = grid.Length;

            int howManyValues = 0;
            for (int i = length-1; i >= 0; i--) 
            {
                int indexY = i;
                int indexX = 0;
                int currHowManyValues = howManyValues;
                
                int[] ints = new int[howManyValues + 1];
                ints[howManyValues] = grid[indexY][indexX];

                while(currHowManyValues != 0)
                {
                    indexY++;
                    indexX++;
                    currHowManyValues--;
                    ints[currHowManyValues] = grid[indexY][indexX];
                }
                currHowManyValues = howManyValues;
                howManyValues++;
                Array.Sort(ints);
                indexY = i;
                indexX = 0;

                while(currHowManyValues != -1)
                {
                    grid[indexY][indexX] = ints[currHowManyValues];
                    indexX++;
                    indexY++;
                    currHowManyValues--;
                }
            }

            howManyValues = length-2;
            for (int i = 1; i < length-1; i++)
            {
                int indexY = 0;
                int indexX = i;
                int currHowManyValues = howManyValues;

                int[] ints = new int[currHowManyValues+1];
                ints[currHowManyValues] = grid[indexY][indexX];

                while (currHowManyValues != 0)
                {
                    indexY++;
                    indexX++;
                    currHowManyValues--;
                    ints[currHowManyValues] = grid[indexY][indexX];
                }
                currHowManyValues = length - i-1;
                howManyValues--;
                Array.Sort(ints);
                indexY = 0;
                indexX = i;
                int indexInts = 0;
                while (currHowManyValues != -1)
                {
                    grid[indexY][indexX] = ints[indexInts];
                    indexX++;
                    indexY++;
                    currHowManyValues--;
                    indexInts++;
                }
            }


            return grid;
        }

    }
}

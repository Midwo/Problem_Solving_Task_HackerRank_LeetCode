using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3070
    {
        ////(3070.) Count Submatrices with Top-Left Element and Sum Less Than k (MEDIUM)
        public int CountSubmatrices(int[][] grid, int k)
        {
            int countSubmatices = 0;
            int row = grid.Length;
            int column = grid[0].Length;
            int maxColumnLenght = column;
            int[] sumColumn = new int[column];
            
            for (int indexRow = 0; indexRow < row; indexRow++)
            {
                if (sumColumn[0] >= k)
                {
                    break;
                }

                int currSum = 0;
                
                for (int indexColumn = 0; indexColumn < maxColumnLenght; indexColumn++)
                {
                    currSum += grid[indexRow][indexColumn]+sumColumn[indexColumn];
                    if(currSum <= k)
                    {
                        sumColumn[indexColumn] += grid[indexRow][indexColumn];
                        countSubmatices++;
                    }
                    else
                    {
                        maxColumnLenght = indexColumn;
                        break;
                    }
                }
            }

            return countSubmatices;
        }
    }
}

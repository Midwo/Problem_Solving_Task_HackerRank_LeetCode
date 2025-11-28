using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1380
    {
        ////(1380.) Lucky Numbers in a Matrix (EASY)
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int countColumn = matrix[0].Length;
            int countRow = matrix.Length;

            int[] maxValueColumn = new int[countColumn];
            int[] maxValueRow = new int[countRow];
            IList<int> resultList = new List<int>();

            for (int i = 0; i < countRow; i++)
            {
                maxValueRow[i] = matrix[i][0];
                for (int j = 0; j < countColumn; j++) 
                {
                    if (matrix[i][j] < maxValueRow[i])
                    {
                        maxValueRow[i] = matrix[i][j];
                    }
                    if (matrix[i][j] > maxValueColumn[j])
                    {
                        maxValueColumn[j] = matrix[i][j];
                    }
                }
            }
                        
            foreach (int i in maxValueColumn)
            {
                if (maxValueRow.Contains(i))
                {
                    resultList.Add(i);
                }
            }

            return resultList;
        }
    }
}

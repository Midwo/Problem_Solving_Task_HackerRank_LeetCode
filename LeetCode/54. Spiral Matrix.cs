using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_54
    {
        ////(54.) Spiral Matrix (MEDIUM)
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            int x = matrix[0].Length;
            int y = matrix.Length;

            if (x == 1)
            {
                for (int i = 0; i < y; i++)
                {
                    result.Add(matrix[i][0]);
                }
                return result;
            }

            if (y == 1)
            {
                for (int i = 0; i < x; i++)
                {
                    result.Add(matrix[0][i]);
                }
                return result;
            }

            int blockRange = 0;
            int indexBlockRange = 0;

            while (blockRange * 2 < x-1) 
            {
                switch (indexBlockRange)
                {
                    case 0:
                        for (int j = blockRange; j < x - blockRange - 1; j++) 
                        {
                            result.Add(matrix[blockRange][j]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    case 1:
                        for (int j = blockRange; j < y - blockRange - 1; j++)
                        {
                            result.Add(matrix[j][x - blockRange - 1]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    case 2:
                        for (int j = x - 1 - blockRange; j > blockRange; j--)
                        {
                            result.Add(matrix[y - blockRange-1][j]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                    default:
                        for (int j = y - blockRange - 1; j > blockRange; j--)
                        {
                            result.Add(matrix[j][blockRange]);
                            if (result.Count == x * y)
                            {
                                return result;
                            }
                        }
                        break;
                }

                indexBlockRange++;
                if (indexBlockRange == 4)
                {
                    indexBlockRange = 0;
                    blockRange++;
                    if (result.Count == x * y)
                    {
                        return result;
                    }
                }
            }

            if (result.Count != x * y)
            {
                for (int j = blockRange; j <= x - blockRange - 1; j++)
                {
                    result.Add(matrix[blockRange][j]);
                }
                if (result.Count == x * y)
                {
                    return result;
                }
                for (int j = blockRange + 1; j < y - blockRange; j++)
                {
                    result.Add(matrix[j][blockRange]);
                }
            }
            return result;
        }
    }
}

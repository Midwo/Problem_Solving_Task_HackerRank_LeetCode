using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_799
    {
        ////(799.) Champagne Tower (MEDIUM)
        public double ChampagneTower(int poured, int query_row, int query_glass)
        {
            if (query_row == 0)
            {
                return Math.Min(1, poured);
            }
            double[][] howMany = new double[100][];
            int currRow = 1;
            int colLength = 2;
            int minColIndex = 0;
            howMany[0] = new double[1];
            howMany[0][0] = --poured;
            while (currRow < query_row)
            {
                howMany[currRow] = new double[colLength];
                for (int indexCol = minColIndex; indexCol < colLength-minColIndex; indexCol++)
                {
                    if (indexCol == 0)
                    {
                        howMany[currRow][indexCol] = ((howMany[currRow-1][indexCol])/2)-1;
                    }
                    else if (indexCol < colLength - 1)
                    {
                        double minValue = Math.Max(howMany[currRow - 1][indexCol - 1], 0);
                        howMany[currRow][indexCol] = ((minValue + howMany[currRow - 1][indexCol]) / 2)-1;
                    }
                    else
                    {
                        howMany[currRow][indexCol] = ((howMany[currRow - 1][indexCol-1]) / 2)-1;
                    }
                }
                if (howMany[currRow][minColIndex] <= 1)
                {
                    minColIndex++;
                }
                currRow++;
                colLength++;
            }

            if(query_glass == 0)
            {
                double minValue = Math.Max(howMany[currRow - 1][query_glass], 0);
                return Math.Min(1, minValue / 2);
            }
            else if (query_glass == query_row)
            {
                double minValue = Math.Max(howMany[currRow - 1][query_glass - 1], 0);
                return Math.Min(1, ((howMany[currRow - 1][query_glass - 1]) / 2));
            }
            else
            {
                double minValue1 = Math.Max(howMany[currRow - 1][query_glass], 0);
                double minValue2 = Math.Max(howMany[currRow - 1][query_glass-1], 0);
                return Math.Min(1, ((minValue2 + minValue1) / 2));
            }
        }
    }
}

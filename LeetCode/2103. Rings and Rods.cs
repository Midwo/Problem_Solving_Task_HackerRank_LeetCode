using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2103
    {
        ////(2103.) Rings and Rods (EASY)
        public int CountPoints(string rings)
        {
            int count = 0;
            int[][] countColorPosition = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                countColorPosition[i] = new int[3];
            }

            for (int i = 0; i < rings.Length; i += 2)
            {
                int indexRings = (int)char.GetNumericValue(rings[i+1]);
                switch (rings[i])
                {
                    case 'B':
                        countColorPosition[indexRings][0]++;
                        break;
                    case 'R':
                        countColorPosition[indexRings][1]++;
                        break;
                    default:
                        countColorPosition[indexRings][2]++;
                        break;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                if (countColorPosition[i][0] > 0 && countColorPosition[i][1] > 0 && countColorPosition[i][2] > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

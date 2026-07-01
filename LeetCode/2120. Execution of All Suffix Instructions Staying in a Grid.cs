using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2120
    {
        ////(2120.) Execution of All Suffix Instructions Staying in a Grid (MEDIUM)
        public int[] ExecuteInstructions(int n, int[] startPos, string s)
        {
            int length = s.Length;
            int[] resultTable = new int[s.Length];

            for (int indexStartInstructions = 0; indexStartInstructions < length; indexStartInstructions++)
            {
                int posX = startPos[1];
                int posY = startPos[0];
                int countOperations = 0;

                for (int indexCurrOp = indexStartInstructions; indexCurrOp < length; indexCurrOp++)
                {
                    switch (s[indexCurrOp])
                    {
                        case 'R':
                            posX++;
                            break;
                        case 'L':
                            posX--;
                            break;
                        case 'D':
                            posY++;
                            break;
                        default:
                            posY--;
                            break;
                    }

                    if (posY >= 0 && posY < n && posX >= 0 && posX < n)
                        countOperations++;
                    else
                        break;                    
                }

                resultTable[indexStartInstructions] = countOperations;
            }  

            return resultTable;
        }
    }
}

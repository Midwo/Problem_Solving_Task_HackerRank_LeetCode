using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3602
    {
        ////(3602.) Hexadecimal and Hexatrigesimal Conversion (EASY)
        public string ConcatHex36(int n)
        {
            StringBuilder sb = new StringBuilder();

            int seachrValue1 = n * n;
            int seachrValue2 = seachrValue1*n;

            char[] CharsTable = ['0','1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V','W','X','Y','Z'];
            int[] hexadecimalTable = [1, 16, 256, 4096, 65536, 1048576, 16777216, 268435456];
            int[] hexatrigesimalTable = [1, 36, 1296, 46656, 1679616, 60466176];

            int indexSeachrValue = 0;

            for (int indexHexadecimalTable = hexadecimalTable.Length-1; indexHexadecimalTable >= 0; indexHexadecimalTable--)
            {
                if (seachrValue1 >= hexadecimalTable[indexHexadecimalTable])
                {
                    indexSeachrValue = indexHexadecimalTable;
                    break;
                }
            }

            for (; indexSeachrValue >= 0; indexSeachrValue--)
            {
                int currValue = hexadecimalTable[indexSeachrValue];
                if (currValue > seachrValue1)
                {
                    sb.Append(0);
                }
                else
                {
                    int position = seachrValue1 / currValue;
                    sb.Append(CharsTable[position]);
                    seachrValue1 -= position * (int)Math.Pow(16, indexSeachrValue);
                }
            }

            for (int indexHexatrigesimalTable = hexatrigesimalTable.Length - 1; indexHexatrigesimalTable >= 0; indexHexatrigesimalTable--)
            {
                if (seachrValue2 >= hexatrigesimalTable[indexHexatrigesimalTable])
                {
                    indexSeachrValue = indexHexatrigesimalTable;
                    break;
                }
            }

            for (; indexSeachrValue >= 0; indexSeachrValue--)
            {
                int currValue = (int)hexatrigesimalTable[indexSeachrValue];
                if (currValue > seachrValue2)
                {
                    sb.Append(0);
                }
                else
                {
                    int position = seachrValue2 / currValue;
                    sb.Append(CharsTable[position]);
                    seachrValue2 -= position * (int)Math.Pow(36, indexSeachrValue);
                }
            }


            return sb.ToString();
        }
    }
}

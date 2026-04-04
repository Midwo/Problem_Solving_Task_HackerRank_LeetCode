using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2075
    {
        ////(2075.) Decode the Slanted Ciphertext (MEDIUM)
        public string DecodeCiphertext(string encodedText, int rows)
        {
            int length = encodedText.Length;
            int cols = length / rows;
            
            StringBuilder sbDecodeCipherText = new StringBuilder();

            for (int indexCols = 0; indexCols < cols; indexCols++)
            {
                sbDecodeCipherText.Append(encodedText[indexCols]);
                int currIndexCols = indexCols + 1;
                for (int currRow = 1; currRow < rows; currRow++)
                {
                    if(currRow < rows && currIndexCols < cols)
                    {
                        sbDecodeCipherText.Append(encodedText[currRow*cols+currIndexCols++]);
                    }
                    else
                    {
                        break;
                    }
                }
            } 

            return sbDecodeCipherText.ToString().TrimEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_7
    {
        ////(7.) Reverse Integer (MEDIUM)
        public int Reverse(int x)
        {
            string stringX = x.ToString();
            char[] charX = stringX.ToCharArray();
            string resultString = string.Empty;
            int lengthX = stringX.Length;
            if (x < 0)
            {
                resultString += "-";
                for (int i = lengthX-1; i > 0; i--)
                {
                    //char tempChar = charX[i];
                    //charX[i] = charX[lengthX - i];
                    //charX[lengthX - i] = tempChar;
                    resultString += charX[i];
                }
            }
            else
            {
                for (int i = lengthX-1; i >= 0; i--)
                {
                    //char tempChar = charX[i];
                    //charX[i] = charX[lengthX - i - 1];
                    //charX[lengthX - i - 1] = tempChar;
                    resultString += charX[i];
                }
            }
            long resultLong = Convert.ToInt64(resultString);
            if (Int32.MaxValue <= resultLong || int.MinValue >= resultLong)
            {
                return 0;
            }
            return Convert.ToInt32(resultLong);
        }
    }
}

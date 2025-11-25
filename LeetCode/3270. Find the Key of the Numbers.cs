using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3270
    {
        ////(3270.) Find the Key of the Numbers (EASY)
        public int GenerateKey(int num1, int num2, int num3)
        {
            int[] minIntTable = new int[4] { 10, 10, 10, 10 };

            int indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num1 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num1 /= 10;
                indexResultInts--;
            }
            indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num2 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num2 /= 10;
                indexResultInts--;
            }
            indexResultInts = 3;
            while (indexResultInts != -1)
            {
                int temp = num3 % 10;

                if (minIntTable[indexResultInts] > temp)
                {
                    minIntTable[indexResultInts] = temp;
                }
                num3 /= 10;
                indexResultInts--;
            }

            int result = 0;

            for (int i = 0; i < 4; i++)
            {
                if (minIntTable[i] < 10)
                {
                    result = result * 10 + minIntTable[i];
                }
            }

            return result;
        }
    }
}

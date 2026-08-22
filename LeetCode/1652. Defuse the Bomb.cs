using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1652
    {
        ////(1652.) Defuse the Bomb (EASY)
        public int[] Decrypt(int[] code, int k)
        {
            int lengthCode = code.Length;
            int[] resultTableDecrypt = new int[lengthCode];

            if (k > 0)
            {
                int newIndex = k;

                //int sum = code[1..(k + 1)].Sum();

                //OR

                int sum = 0;

                for (int i = 1; i < (k+1); i++)
                {
                    sum += code[i];
                }

                resultTableDecrypt[0] = sum;

                for (int index = 1; index < lengthCode; index++)
                {
                    newIndex++;
                    if (newIndex == lengthCode)
                    {
                        newIndex = 0;
                    }
                    sum += -code[index] + code[newIndex];
                    resultTableDecrypt[index] = sum;
                }
            }
            else if (k < 0)
            {
                int newIndex = lengthCode - 1 + k;
               
                //int sum = code[newIndex..(lengthCode-1)].Sum();
                
                //OR
                int sum = 0;

                for (int i = newIndex; i < (lengthCode-1); i++)
                {
                    sum += code[i];
                }

                resultTableDecrypt[lengthCode-1] = sum;

                for (int index = lengthCode - 2; index >= 0; index--)
                {
                    newIndex--;
                    if (newIndex == -1)
                    {
                        newIndex = lengthCode - 1;
                    }
                    sum += -code[index] + code[newIndex];
                    resultTableDecrypt[index] = sum;
                }

            }

            return resultTableDecrypt;
        }
    }
}
    



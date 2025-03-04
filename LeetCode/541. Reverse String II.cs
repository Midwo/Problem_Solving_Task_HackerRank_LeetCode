using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_541
    {
        ////(541.) Reverse String II (EASY)
        public string ReverseStr(string s, int k)
        {
            char[] arrayCharS = s.ToCharArray();
            int sLength = s.Length;
            for (int i = 0; i < arrayCharS.Length; i += 2 * k)
            {
                int curLeftIndex = i;
                int curRightIndex = i + k - 1;

                if (curRightIndex >= sLength)
                {
                    curRightIndex = sLength - 1;
                }

                while (curLeftIndex < curRightIndex)
                {
                    char temp = arrayCharS[curLeftIndex];
                    arrayCharS[curLeftIndex] = arrayCharS[curRightIndex];
                    arrayCharS[curRightIndex] = temp;

                    curLeftIndex++;
                    curRightIndex--;
                }
            }

            return new String(arrayCharS);
        }
    }
}

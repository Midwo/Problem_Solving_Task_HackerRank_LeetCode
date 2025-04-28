using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1047
    {
        ////(1047.) Remove All Adjacent Duplicates In String (EASY)
        public string RemoveDuplicates(string s)
        {
            char[] charS = s.ToCharArray();
            int index = 0;

            for (int i = 0; i < charS.Length; i++)
            {
                charS[index] = charS[i];
                if (index > 0 && charS[index] == charS[index - 1])
                {
                    index -= 2;
                }
                index++;
            }

            return new String(charS, 0, index);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_848
    {
        ////(848.) Shifting Letters (MEDIUM)
        public string ShiftingLetters(string s, int[] shifts)
        {
            char[] charsAfterOp = new char[s.Length];

            int howManyOperations = 0;

            for (int i = shifts.Length - 1; i >= 0; i--) 
            { 
                howManyOperations = (howManyOperations + shifts[i]) % 26;
                int numberAsci = howManyOperations + s[i];
                if (numberAsci > 'z')
                {
                    numberAsci -= 26;
                }
                charsAfterOp[i] = (char)numberAsci;
            }
            
            return new string (charsAfterOp);
        }
    }
}

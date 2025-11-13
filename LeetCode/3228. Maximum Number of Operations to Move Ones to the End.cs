using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3228
    {
        ////(3228.) Maximum Number of Operations to Move Ones to the End (MEDIUM)
        public int MaxOperations(string s)
        {
            int result = 0;

            int countZero = 0;
            int lastChar = int.MaxValue;
            
            for (int i = s.Length-1; i >= 0; i--)
            {
                if (s[i] == '0' && lastChar != s[i])
                {
                    countZero++;
                }
                else if (s[i] == '1')
                {
                    result += countZero;
                }

                lastChar = s[i];
            }

            return result;
        }
    }
}

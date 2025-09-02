using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1528
    {
        ////(1528.) Shuffle String (EASY)
        public string RestoreString(string s, int[] indices)
        {
            char[] resultChars = new char[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                resultChars[indices[i]] = s[i];
                
            }

            return new string (resultChars);
        }
    }
}

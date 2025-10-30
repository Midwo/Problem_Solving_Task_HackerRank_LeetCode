using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3210
    {
        ////(3210.) Find the Encrypted String (EASY)
        public string GetEncryptedString(string s, int k)
        {
            int length = s.Length;
            k = k % length;

            StringBuilder sb = new StringBuilder();
            int index = 0;
            int currIndexS = k;

            while (index < length) 
            {
                if (currIndexS == length)
                {
                    currIndexS = 0;
                }
                sb.Append(s[currIndexS++]);
                index++;
            }

            return new string(sb.ToString());
        }
    }
}

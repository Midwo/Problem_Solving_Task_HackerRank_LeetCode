using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1957
    {
        ////(1957.) Delete Characters to Make Fancy String (EASY)
        public string MakeFancyString(string s)
        {
            char lastChar = s[0];
            int count = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(lastChar);

            for (int i = 1 ; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    count++;
                    if (count <= 2)
                    {
                        sb.Append(lastChar);
                    }
                }
                else
                {
                    count = 1;
                    lastChar = s[i];
                    sb.Append(lastChar);
                }
            }

            return new string (sb.ToString());
        }
    }
}

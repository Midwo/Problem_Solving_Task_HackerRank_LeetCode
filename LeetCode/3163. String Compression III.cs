using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3163
    {
        ////(3163.) String Compression III (MEDIUM)
        public string CompressedString(string word)
        {
            int count = 1;
            char lastChar = word[0];
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < word.Length; i++) 
            { 
                char currChar = word[i];
                if (currChar == lastChar)
                {
                    count++;
                    if(count == 9)
                    {
                        sb.Append(9);
                        sb.Append(currChar);
                        count = 0;
                    }
                }
                else
                {
                    if (count > 0)
                    {
                        sb.Append(count);
                        sb.Append(lastChar);
                    }
                    count = 1;
                    lastChar = currChar;
                }
            }

            if (count > 0) 
            {
                sb.Append(count);
                sb.Append(lastChar);
            }

            return sb.ToString();
        }
    }
}

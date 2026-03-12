using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3582
    {
        ////(3582.) Generate Tag for Video Caption (EASY)
        public string GenerateTag(string caption)
        {
            StringBuilder sb = new StringBuilder();

            string[] splitCaption = caption.Split(' ');
            int length = 99;
            int currLength = 0;
            sb.Append('#');
            bool firstLower = true;
            if (splitCaption[0].Length != 0)
            {
                firstLower = false;
                sb.Append(splitCaption[0][0].ToString().ToLower());
                currLength = Math.Min(length, splitCaption[0].Length);
                length -= currLength - 1;
                sb.Append(splitCaption[0][1..currLength].ToLower());
            }

            for (int i = 1; i < splitCaption.Length; i++)
            {
                if (splitCaption[i].Length == 0)
                {
                    continue;
                }
                length--;
                if (length < 1)
                {
                    break;
                }
                if (firstLower)
                {
                    sb.Append(splitCaption[i][0].ToString().ToLower());
                    firstLower = false;
                }
                else
                {
                    sb.Append(splitCaption[i][0].ToString().ToUpper());
                }
                currLength = Math.Min(length, splitCaption[i].Length);
                length -= currLength-1;
                sb.Append(splitCaption[i][1..currLength].ToLower());
                if(length < 1)
                {
                    break;
                }
            }

            return sb.ToString();
        }
    }
}

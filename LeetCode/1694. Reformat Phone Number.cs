using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1694
    {
        ////(1694.) Reformat Phone Number (EASY)
        public string ReformatNumber(string number)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char currChar in number)
            {
                if(currChar != ' ' && currChar != '-')
                {
                    sb.Append(currChar);
                }
            }

            StringBuilder resultSb = new StringBuilder();
            int length = sb.Length;

            int index = 0;

            while(index != length)
            {
                if(index >= length - 4)
                {
                    if (index == length - 4)
                    {
                        resultSb.Append(sb[index]);
                        resultSb.Append(sb[index + 1]);
                        resultSb.Append('-');
                        resultSb.Append(sb[index + 2]);
                        resultSb.Append(sb[index + 3]);
                    }
                    else if (index == length - 3)
                    {
                        resultSb.Append(sb[index]);
                        resultSb.Append(sb[index + 1]);
                        resultSb.Append(sb[index + 2]);
                    }
                    else
                    {
                        resultSb.Append(sb[index]);
                        resultSb.Append(sb[index + 1]);
                    }
                    index = length;
                }
                else
                {
                    resultSb.Append(sb[index]);
                    resultSb.Append(sb[index + 1]);
                    resultSb.Append(sb[index +2 ]);
                    resultSb.Append('-');
                    index += 3;
                }
            }
            

            return resultSb.ToString();
        }
    }
}

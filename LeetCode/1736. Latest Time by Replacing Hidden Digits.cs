using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1736
    {
        ////(1736.) Latest Time by Replacing Hidden Digits (EASY)
        public string MaximumTime(string time)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                char currChar = time[i];
                if (currChar == '?')
                {
                    if(i == 0 && time[1] == '?' || i == 0 && time[1] < '4')
                    {
                        sb.Append('2');
                    }
                    else if (i == 0 && time[1] > '3')
                    {
                        sb.Append('1');
                    }
                    else if(i == 1 && sb[0] < '2')
                    {
                        sb.Append('9');
                    }
                    else if(i == 1 && sb[0] == '2')
                    {
                        sb.Append('3');
                    }
                    else if (i == 3)
                    {
                        sb.Append('5');
                    }
                    else if(i == 4)
                    {
                        sb.Append('9');
                    }
                }
                else
                {
                    sb.Append(currChar);
                }
            }
            return sb.ToString();
        }
    }
}

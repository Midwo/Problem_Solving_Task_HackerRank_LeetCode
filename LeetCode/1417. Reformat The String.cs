using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1417
    {
        ////(1417.) Reformat The String (EASY)
        public string Reformat(string s)
        {
            bool correctFormat = true;
            char lastCharS = ' ';
            int statusLastChar = 0;
            int statusCurrChar = 0;
            List<char> listLetters = new List<char>();
            List<char> listNumbers = new List<char>();

            for (int i = 0; i < s.Length; i++) 
            {
                lastCharS = s[i];
                if(lastCharS >= 'a' && lastCharS <= 'z')
                {
                    listLetters.Add(lastCharS);
                    statusCurrChar = 1;
                }
                else
                {
                    listNumbers.Add(lastCharS);
                    statusCurrChar = 2;
                }

                if (correctFormat && statusLastChar == statusCurrChar)
                {
                    correctFormat = false;
                }
                else
                {
                    statusLastChar = statusCurrChar;
                }

            }

            if (correctFormat)
            {
                return s;
            }
            else if (Math.Abs(listLetters.Count - listNumbers.Count) > 1)
            {
                return "";
            }
            else
            {
                if(listNumbers.Count > listLetters.Count)
                {
                    return GenerateReformatString(listNumbers, listLetters, true);
                }
                else if (listLetters.Count > listNumbers.Count)
                {
                    return GenerateReformatString(listLetters, listNumbers, true);
                }
                else
                {
                    return GenerateReformatString(listLetters, listNumbers, false);
                }
            }
        }

        private string GenerateReformatString(List<char> longerList, List<char> shorterList, bool longerStatus)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < shorterList.Count; i++)
            {
                sb.Append(longerList[i]);
                sb.Append(shorterList[i]);
            }

            if (longerStatus)
            {
                sb.Append(longerList[longerList.Count - 1]);
            }
            return sb.ToString();
        }
    }
}

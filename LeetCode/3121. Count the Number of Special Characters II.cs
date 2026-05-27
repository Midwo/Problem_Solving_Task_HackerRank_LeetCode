using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3121
    {
        ////(3121.) Count the Number of Special Characters II (MEDIUM)
        public int NumberOfSpecialChars(string word)
        {
            var statusChar = new int[26];
            ////Status info for statusChar:
            //-1 - block this char, upper before lower
            //0 - no detect
            //1 - lower detect, upper no detect
            //2 - upper after lower

            foreach (char currChar in word)
            {
                if (char.IsLower(currChar))
                {
                    int indexStatusChar = currChar - 'a';

                    if (statusChar[indexStatusChar] == 0 || statusChar[indexStatusChar] == 1)
                    {
                        statusChar[indexStatusChar] = 1;
                    }
                    else
                    {
                        statusChar[indexStatusChar] = -1;
                    }
                }
                else
                {
                    int indexStatusChar = currChar - 'A';

                    if (statusChar[indexStatusChar] == 2 || statusChar[indexStatusChar] == 1)
                    {
                        statusChar[indexStatusChar] = 2;
                    }
                    else
                    {
                        statusChar[indexStatusChar] = -1;
                    }
                }
            }

            int correctSpecialChar = 0;
            foreach (int valueStatus in statusChar)
            {
                if (valueStatus == 2)
                    correctSpecialChar++;
            }

            return correctSpecialChar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2309
    {
        ////(2309.) Greatest English Letter in Upper and Lower Case (EASY)
        public string GreatestLetter(string s)
        {
            bool[] letterStatus = new bool[52];
            char currChar;

            for (int i = 0; i < s.Length; i++)
            {
                currChar = s[i];
                if (currChar >= 'a')
                {
                    letterStatus[currChar - 'a'] = true;
                }
                else
                {
                    letterStatus[currChar - 'A'+26] = true;
                }
            }

            for (int i = 51; i >= 26; i--)
            {
                if (letterStatus[i-26] && letterStatus[i])
                {
                    return ((char)('A' + i-26)).ToString();
                }
            }

            return "";



            //bool[] letterLower = new bool[26];
            //bool[] letterUpper = new bool[26];
            //char currChar;

            //for (int i = 0; i < s.Length; i++) 
            //{
            //    currChar = s[i];
            //    if (currChar >= 'a')
            //    {
            //        letterLower[currChar - 'a'] = true;
            //    }
            //    else
            //    {
            //        letterUpper[currChar - 'A'] = true;
            //    }
            //}

            //for (int i = 25; i >= 0; i--) 
            //{ 
            //    if (letterLower[i] && letterUpper[i])
            //    {
            //        return ((char)('A' + i)).ToString();
            //    }
            //}

            //return ""; 
        }
    }
}

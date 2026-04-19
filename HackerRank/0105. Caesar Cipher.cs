using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0105
    {
        ////105. Caesar Cipher (EASY)
        public string caesarCipher(string s, int k)
        {
            ////Solution 1 (New)
            var sbCaesarCipher = new StringBuilder();
            var rotationValue = k % 26;

            foreach (var currChar in s)
            {
                if (currChar >= 'a' && currChar <= 'z')
                {
                    int shifted = (currChar - 'a' + rotationValue) % 26 + 'a';
                    sbCaesarCipher.Append((char)shifted);
                }
                else if (currChar >= 'A' && currChar <= 'Z')
                {
                    int shifted = (currChar - 'A' + rotationValue) % 26 + 'A';
                    sbCaesarCipher.Append((char)shifted);
                }
                else
                {
                    sbCaesarCipher.Append(currChar);
                }
            }

            return sbCaesarCipher.ToString();

            ////Solution 2 (Old)
            //string newS = string.Empty;
            //int intChar = 0;
            //int moduloHowManyChar = k % 26;
            //foreach (char i in s)
            //{
            //    intChar = (int)i;
            //    if ((int)i >= 97 && (int)i <= 122)
            //    {
            //        intChar = (int)i + moduloHowManyChar;
            //        if (intChar > 122)
            //        {
            //            intChar = 96 + intChar - 122;
            //        }
            //    }
            //    else if ((int)i >= 65 && (int)i <= 90)
            //    {
            //        intChar = (int)i + moduloHowManyChar;
            //        if (intChar > 90)
            //        {
            //            intChar = 64 + intChar - 90;
            //        }
            //    }
            //    newS += (char)intChar;
            //}
            //return newS;
        }
    }
}

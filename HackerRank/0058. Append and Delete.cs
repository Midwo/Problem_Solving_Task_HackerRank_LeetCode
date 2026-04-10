using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0058
    {
        ////58. Append and Delete (EASY)
        public string appendAndDelete(string s, string t, int k)
        {
            int countCorrectDigit = 0;

            int lengthS = s.Length;
            int lengthT = t.Length;

            if (k >= lengthS + lengthT)
            {
                return "Yes";
            }

            int minLenght = Math.Min(lengthS, lengthT);

            for (int i = 0; i < minLenght; i++) 
            {
                if (s[i] == t[i])
                {
                    countCorrectDigit++;
                }
                else
                {
                    break;
                }
            }
            int howManyOperations = lengthS - countCorrectDigit + lengthT - countCorrectDigit;
            if (howManyOperations > k)
            {
                return "No";
            }
            else if (howManyOperations != k && (k-howManyOperations) % 2 == 1)
            {
                return "No";
            }
            return "Yes";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1684
    {
        ////(1684.) Count the Number of Consistent Strings (EASY)
        public int CountConsistentStrings(string allowed, string[] words)
        {
            List<char> allowedCharList = allowed.ToList();
            int result = 0;
            bool allGood = true;

            for (int i = 0; i < words.Length; i++)
            {
                allGood = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!allowedCharList.Contains(words[i][j]))
                    {
                        allGood = false;
                        break;
                    }
                }
                if (allGood) 
                {
                    result++;
                }
            }

            return result;
        }
    }
}

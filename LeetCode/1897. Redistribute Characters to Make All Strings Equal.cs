using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1897
    {
        ////(1897.) Redistribute Characters to Make All Strings Equal (EASY)
        public bool MakeEqual(string[] words)
        {
            int[] countChar = new int[26];
            int length = words.Length;

            foreach (string word in words) 
            {
                foreach (char currChar in word) 
                {
                    countChar[currChar - 'a']++;
                }
            }

            foreach (int currChar in countChar)
            {
                if(currChar > 0 && currChar % length != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

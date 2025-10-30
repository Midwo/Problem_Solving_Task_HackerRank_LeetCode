using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2586
    {
        ////(2586.) Count the Number of Vowel Strings in Range (EASY)
        public int VowelStrings(string[] words, int left, int right)
        {
            int count = 0;

            for(int j = left; j <= right; j++) 
            {
                int length = words[j].Length-1;
                if (words[j][0] == 'a' | words[j][0] == 'e' | words[j][0] == 'i' | words[j][0] == 'o' | words[j][0] == 'u') 
                {
                    if (words[j][length] == 'a' | words[j][length] == 'e' | words[j][length] == 'i' | words[j][length] == 'o' | words[j][length] == 'u')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2000
    {
        ////(2000.) Reverse Prefix of Word (EASY)
        public string ReversePrefix(string word, char ch)
        {
            int indexDetected = -1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    indexDetected = i;
                    break;
                }
            }

            if (indexDetected < 0) 
            {
                return word;
            }
            else
            {
                string temp1 = (word.Substring(0, indexDetected+1));
                char[] tempChar = temp1.ToCharArray();
                Array.Reverse(tempChar);
                string temp2 = word.Substring(indexDetected + 1, word.Length-1-indexDetected);

                return new string(tempChar) + temp2;
            }
        }
    }
}

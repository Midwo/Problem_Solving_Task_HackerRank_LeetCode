using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2490
    {
        ////(2490.) Circular Sentence (EASY)
        public bool IsCircularSentence(string sentence)
        {
            char lastChar = ' ';
            bool check = false;
            char currChar = ' ';
            for (int index = 0; index < sentence.Length; index++)
            {
                currChar = sentence[index];
                
                if (currChar == ' ')
                {
                    check = true;
                }
                else if (!check)
                {
                    lastChar = currChar;
                }
                else
                {
                    check = false;
                    if(lastChar != currChar)
                    {
                        return false;
                    }
                    lastChar = currChar;
                }
            }


            return lastChar == sentence[0];

        }
    }
}

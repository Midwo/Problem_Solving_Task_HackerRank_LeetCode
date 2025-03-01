using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_520
    {
        ////(520.) Detect Capital (EASY)
        public bool DetectCapitalUse(string word)
        {
            int lengthWord = word.Length-1;
            bool lastWordUpper = false;
            if (word[lengthWord] < 97) { lastWordUpper = true;}
            if (word[0] >= 97)
            {
                for (int i = 1; i <= lengthWord; i++)
                {
                    if ((word[i] < 97))
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (lastWordUpper)
                {
                    for (int i = 1; i <= lengthWord; i++)
                    {
                        if ((word[i] <= 97) != lastWordUpper)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= lengthWord; i++)
                    {
                        if ((word[i] >= 97) == lastWordUpper)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

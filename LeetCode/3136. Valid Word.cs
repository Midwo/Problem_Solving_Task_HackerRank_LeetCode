using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3136
    {
        ////(3136.) Valid Word (EASY)
        public bool IsValid(string word)
        {
            int length = word.Length;

            if (length < 3) return false;

            bool result = true;
            int vowel = 0;
            int consonant = 0;

            for (int i = 0; i < length; i++)
            {
                if (word[i] >= 65 && word[i] <= 90 || word[i] >= 97 && word[i] <= 122)
                {
                    if (vowel < 1 || consonant < 1)
                    {
                        if (word[i] == 'a' || word[i] == 'A' || word[i] == 'e' || word[i] == 'E' || word[i] == 'i' || word[i] == 'I' || word[i] == 'o' ||
                            word[i] == 'O' || word[i] == 'u' || word[i] == 'U')
                        {
                            vowel++;
                        }
                        else
                        {
                            consonant++;
                        }
                    }
                }
                else if (word[i] < 48 || word[i] > 57)
                {
                    result = false;
                    break;
                }
            }

            if(result == false || vowel == 0 || consonant == 0)
            {
                return false;
            }

            return result;
        }
    }
}

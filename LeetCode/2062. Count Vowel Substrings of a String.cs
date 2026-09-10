using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2062
    {
        ////(2062.) Count Vowel Substrings of a String (EASY)
        public int CountVowelSubstrings(string word)
        {
            Span<int> countVovels = stackalloc int[5];
            int length = word.Length;
            int resultCount = 0;

            for (int indexStart = 0; indexStart < length - 4; indexStart++)
            {
                char currChar = word[indexStart];
                if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u')
                {
                    bool status = false;
                    countVovels.Fill(0);
                    AddCount(currChar, countVovels);
                    for (int indexSecondChar = indexStart+1; indexSecondChar < length; indexSecondChar++)
                    {
                        currChar = word[indexSecondChar];
                        if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u')
                        {
                            if (status)
                            {
                                resultCount++;
                                continue;
                            }
                            else if (indexSecondChar - indexStart >= 4)
                            {
                                AddCount(currChar, countVovels);
                                if (countVovels[0] > 0 && countVovels[1] > 0 && countVovels[2] > 0 && countVovels[3] > 0 && countVovels[4] > 0)
                                {
                                    resultCount++;
                                    status = true;
                                    continue;
                                }
                                continue;
                            }
                            AddCount(currChar, countVovels);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            void AddCount(char currChar, Span<int> countVovels)
            {
                switch (currChar) 
                { 
                    case 'a':
                        countVovels[0]++;
                        break;
                    case 'e':
                        countVovels[1]++;
                        break;
                    case 'i':
                        countVovels[2]++;
                        break;
                    case 'o':
                        countVovels[3]++;
                        break;
                    case 'u':
                        countVovels[4]++;
                        break;
                    default:
                        break;
                }
            }

            return resultCount;
        }
    }
}

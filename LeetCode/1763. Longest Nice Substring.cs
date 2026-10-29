using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1763
    {
        ////(1763.) Longest Nice Substring (EASY)
        public string LongestNiceSubstring(string s)
        {
            int[] countChars = new int[53];

            foreach (char currChar in s) 
            { 
                if(currChar >= 'a' && currChar <= 'z')
                    countChars[currChar - 'a']++;
                else
                    countChars[currChar - 'A'+27]++;
            }

            int length = s.Length;
            int startIndexMaxLength = -1;
            int endIndexMaxLength = -1;
            int maxLength = 0;

            for (int startIndex = 0; startIndex < length - maxLength; startIndex++)
            {
                char currChar = s[startIndex];
                int[] currCountChars = new int[56];

                if (currChar >= 'a' && currChar <= 'z')
                {
                    if (countChars[currChar - 'a' + 27] == 0)
                        continue;
                    else
                        currCountChars[currChar - 'a']++;
                }
                else
                {
                    if (countChars[currChar - 'A'] == 0)
                        continue;
                    else
                        currCountChars[currChar - 'A' + 27]++;
                }

                for (int nextIndexes = startIndex + 1; nextIndexes < length; nextIndexes++)
                {
                    char secondChar = s[nextIndexes];
                    bool breakStatus = false;

                    if (secondChar >= 'a' && secondChar <= 'z')
                    {
                        if(countChars[secondChar - 'a'] == 0 || countChars[secondChar - 'a'+27] == 0)
                        {
                            breakStatus = true;
                            break;
                        }
                        else
                            currCountChars[secondChar - 'a']++;

                    }
                    else
                    {
                        //Console.WriteLine(countChars[secondChar - 'A']);
                        //Console.WriteLine(countChars[secondChar - 'A'+ 27]);
                        if (countChars[secondChar - 'A'] == 0 || countChars[secondChar - 'A' + 27] == 0)
                        {
                            breakStatus = true;
                            break;
                        }
                        else
                            currCountChars[secondChar - 'A' + 27]++;
                    }

                    bool statusCorrect = true;

                    for (int i = 0; i < 26; i++)
                    {
                        if (currCountChars[i] > 0 || currCountChars[i+27] > 0)
                        {
                            if (currCountChars[i] == 0 || currCountChars[i + 27] == 0)
                            {
                                statusCorrect = false;
                                break;
                            }
                        }
                    }

                    if (statusCorrect)
                    {
                        if(nextIndexes - startIndex +1 > maxLength)
                        {
                            startIndexMaxLength = startIndex;
                            endIndexMaxLength = nextIndexes;
                            maxLength = nextIndexes - startIndex + 1;
                        }
                    }
                }

                if (currChar >= 'a' && currChar <= 'z')
                    countChars[currChar - 'a']--;
                else
                    countChars[currChar - 'A' + 27]--;
            } 

            if(maxLength > 0)
            {
                return s[startIndexMaxLength..(endIndexMaxLength+1)];
            }

            return "";
        }
    }
}

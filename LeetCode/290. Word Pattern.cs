using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_290
    {
        ////(290.) Word Pattern (EASY)
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dictionaryForPatternAndStringS = new Dictionary<char, string>();
            int currIndexS = 0;
            string currWorld = string.Empty;
            int howLongS = s.Length;
            bool result = true;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (currIndexS >= howLongS)
                {
                    return false;
                }
                if (dictionaryForPatternAndStringS.ContainsKey(pattern[i]))
                {
                    currWorld = string.Empty;
                    for (int j = currIndexS; j < howLongS; j++)
                    {
                        if (s[j] != (char)32)
                        {
                            currWorld += s[j];
                        }
                        else
                        {
                            currIndexS = j + 1;
                            break;
                        }
                        currIndexS = j + 1;
                    }
                    if (dictionaryForPatternAndStringS[pattern[i]] != currWorld)
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    currWorld = string.Empty;
                    for (int j = currIndexS; j < howLongS; j++)
                    {
                        if (s[j] != (char)32)
                        {
                            currWorld += s[j];
                        }
                        else
                        {
                            currIndexS = j + 1;
                            break;
                        }
                        currIndexS = j + 1;
                    }
                    if (dictionaryForPatternAndStringS.ContainsValue(currWorld))
                    {
                        result = false;
                        break;
                    }
                    dictionaryForPatternAndStringS.Add(pattern[i], currWorld);
                }
            }
            if (currIndexS < howLongS)
            {
                return false;
            }
            return result;
        }
    }
}

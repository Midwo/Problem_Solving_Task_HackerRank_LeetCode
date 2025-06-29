using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_76
    {
        ////(76.) Minimum Window Substring (HARD)
        public string MinWindow(string s, string t)
        {
            Dictionary<char, int> dictionaryForT = new Dictionary<char, int>();
            int lenghtS = s.Length;
            int lenghtT = t.Length;
            int leftIndex = 0;
            int rightIndex = lenghtT-1;
            int countCharDictionaryForT = 0;
            int minLengthResult = int.MaxValue;
            string stringResult = string.Empty;

            if (lenghtS < lenghtT)
            {
                return "";
            }

            for (int i = 0; i < lenghtT; i++)
            {
                if (!dictionaryForT.ContainsKey(t[i]))
                {
                    dictionaryForT.Add(t[i], 1);
                    countCharDictionaryForT++;
                }
                else
                {
                    dictionaryForT[t[i]]++;
                    countCharDictionaryForT++;
                }
            }

            Dictionary<char, int> currDictionaryForT = dictionaryForT;

            for (int i = countCharDictionaryForT-1; i >= 0; i--)
            {
                if (dictionaryForT.ContainsKey(s[i]))
                {
                    if (dictionaryForT[s[i]] > 0)
                    {
                        countCharDictionaryForT--;
                        dictionaryForT[s[i]]--;
                    }
                    else
                    {
                        dictionaryForT[s[i]]--;
                    }
                }
            }
            if (countCharDictionaryForT == 0)
            {
                return s.Substring(0, rightIndex + 1 - leftIndex);
            }

            while (rightIndex != lenghtS-1 || leftIndex - rightIndex < lenghtT || minLengthResult == lenghtT)
            {
                if(countCharDictionaryForT == 0)
                {
                    if (minLengthResult > rightIndex - leftIndex)
                    {
                        minLengthResult = rightIndex - leftIndex+1;
                        stringResult = s.Substring(leftIndex, rightIndex+1-leftIndex);
                    }

                    if (dictionaryForT.ContainsKey(s[leftIndex]))
                    {
                        if (dictionaryForT[s[leftIndex]] < 0)
                        {
                            dictionaryForT[s[leftIndex]]++;
                        }
                        else
                        {
                            countCharDictionaryForT++;
                            dictionaryForT[s[leftIndex]]++;
                        }
                    }

                    leftIndex++;
                }
                else
                {
                    rightIndex++;
                    if (rightIndex < lenghtS)
                    {
                        if (dictionaryForT.ContainsKey(s[rightIndex]))
                        {
                            if (dictionaryForT[s[rightIndex]] > 0)
                            {
                                countCharDictionaryForT--;
                                dictionaryForT[s[rightIndex]]--;
                            }
                            else
                            {
                                dictionaryForT[s[rightIndex]]--;
                            }             
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }

            return stringResult;
        }
    }
}

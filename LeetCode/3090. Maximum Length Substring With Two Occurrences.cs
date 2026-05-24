using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3090
    {
        ////(3090.) Maximum Length Substring With Two Occurrences (EASY)
        public int MaximumLengthSubstring(string s)
        {
            ////Solution 1 - (window method)

            int length = s.Length;
            int indexL = 0;
            int indexR = 0;
            var freqChars = new int[26];
            int maxLengthSubstring = 0;

            while (indexR != length)
            {
                int currIndexFreq = s[indexR] - 'a';
                freqChars[currIndexFreq]++;

                while (freqChars[currIndexFreq] > 2)
                { 
                        int indexFreq = s[indexL] - 'a';
                        freqChars[indexFreq]--;
                        indexL++;
                }

                maxLengthSubstring = Math.Max(maxLengthSubstring, indexR - indexL+1);
                indexR++;
            }

            return maxLengthSubstring;

            ////Solution 2
            //int length = s.Length;
            //int maxLengthSubstring = 0;

            //for (int startIndex = 0; startIndex < length; startIndex++) 
            //{ 
            //    var freqChars = new int[26];
            //    freqChars[s[startIndex] - 'a']++;
            //    int currMaxLength = 1;
            //    for (int nextIndexes = startIndex+1; nextIndexes < length; nextIndexes++)
            //    {
            //        int currIndexFreq = s[nextIndexes] - 'a';
            //        freqChars[currIndexFreq]++;

            //        if (freqChars[currIndexFreq] > 2)
            //        {
            //            break;
            //        }

            //        currMaxLength++;
            //    }

            //    maxLengthSubstring = Math.Max(currMaxLength, maxLengthSubstring);
            //}

            //return maxLengthSubstring;
        }
    }
}

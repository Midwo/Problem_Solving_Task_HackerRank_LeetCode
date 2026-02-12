using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3713
    {
        ////(3713.) Longest Balanced Substring I (MEDIUM)
        public int LongestBalanced(string s)
        {
            int maxLengthBalancedString = 1;
            int[] countChar = new int[26];
            int lengthS = s.Length;

            for (int indexS = 0; indexS < lengthS; indexS++)
            {
                if (lengthS - indexS <= maxLengthBalancedString) break;
                Array.Fill(countChar, 0);
                countChar[s[indexS] -'a']++;
                int currLength = 1;
                for (int indexNextChars = indexS+1; indexNextChars < lengthS; indexNextChars++)
                {
                    bool status = true;
                    countChar[s[indexNextChars]-'a']++;
                    currLength++;
                    int currCountForAll = 0;
                    foreach (var currCountCharValue in countChar)
                    {
                        if (currCountCharValue > 0 && currCountForAll == 0 || currCountCharValue > 0 && currCountForAll == currCountCharValue)
                        {
                            currCountForAll = currCountCharValue;
                        }
                        else if (currCountCharValue > 0)
                        {
                            status = false;
                            break;
                        }
                    }

                    if (status == true)
                    {
                        maxLengthBalancedString = Math.Max(maxLengthBalancedString, currLength);
                    }
                }
            }  

            return maxLengthBalancedString;
        }
    }
}

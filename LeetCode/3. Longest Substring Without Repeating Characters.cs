using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3
    {
        ////(3.) Longest Substring Without Repeating Characters (MEDIUM)
        public int LengthOfLongestSubstring(string s)
        {
            int lengthOfLongestSubstring = 0;
            int currlengthOfLongestSubstring = 0;
            int lengthS = s.Length;
            var currHashSet = new HashSet<char>();
            for (int i = 0; i < lengthS; i++)
            {
                currlengthOfLongestSubstring = 0;
                if (lengthOfLongestSubstring < lengthS - i || lengthOfLongestSubstring == lengthS)
                {

                    for (int j = i; j < lengthS; j++)
                    {
                        if (!currHashSet.Add(s[j]))
                        {
                            lengthOfLongestSubstring = lengthOfLongestSubstring < j - i ? j - i : lengthOfLongestSubstring;
                            break;
                        }
                        currlengthOfLongestSubstring++;
                        lengthOfLongestSubstring = lengthOfLongestSubstring < currlengthOfLongestSubstring ? currlengthOfLongestSubstring : lengthOfLongestSubstring;
                    }
                    currHashSet.Clear();
                }
                else
                {
                    break;
                }
            }
            
            return lengthOfLongestSubstring;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_763
    {
        ////(763.) Partition Labels (MEDIUM)
        public IList<int> PartitionLabels(string s)
        {
            int[] lastCharTable = new int[26];
            int lengthS = s.Length;
            IList<int> result = new List<int>();
            int startIndex = 0;
            int currMax = int.MinValue +1;

            for (int i = 0; i < lengthS; i++)
            {
                lastCharTable[s[i]-'a'] = i;
            }

            while(startIndex <= lengthS - 1)
            {
                int copyStartIndex = startIndex;
                while(startIndex != currMax)
                {
                    if(currMax < lastCharTable[s[startIndex] - 'a'])
                    {
                        currMax = lastCharTable[s[startIndex] - 'a'];
                        if(currMax == startIndex)
                        { 
                            break;
                        }
                    }
                    startIndex++;
                }
                result.Add((startIndex) - copyStartIndex+1);
                startIndex++;
            }

            return result;
        }
    }
}

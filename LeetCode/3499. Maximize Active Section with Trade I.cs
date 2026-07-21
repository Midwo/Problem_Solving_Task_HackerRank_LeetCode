using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3499
    {
        ////(3499.) Maximize Active Section with Trade I (MEDIUM)
        public int MaxActiveSectionsAfterTrade(string s)
        {
            List<int[]> manualSplitS = new List<int[]>();
            int count = 1;
            char lastChar = s[0];
            int currOneCount = 0;

            for (int index = 1; index < s.Length; index++)
            {
                if (s[index] != lastChar)
                {
                    manualSplitS.Add(new int[2] { (lastChar - '0'), count });
                    if (lastChar - '0' == 1)
                        currOneCount += count;
                    lastChar = s[index];
                    count = 1;
                }
                else
                    count++;
            }

            if (lastChar - '0' == 1)
                currOneCount += count;

            manualSplitS.Add(new int[2] { (lastChar - '0'), count });

            int maxZeroBetweenOne = 0;

            int countSplits = manualSplitS.Count;

            for (int indexSplits = 1; indexSplits < countSplits-1; indexSplits++) 
            {
                if (manualSplitS[indexSplits][0] == 1 && manualSplitS[indexSplits-1][0] == 0 && manualSplitS[indexSplits+1][0] == 0)
                {
                    maxZeroBetweenOne = Math.Max(maxZeroBetweenOne, (manualSplitS[indexSplits - 1][1]+ manualSplitS[indexSplits + 1][1]));
                }
            }


            return maxZeroBetweenOne + currOneCount;

        }
    }
}

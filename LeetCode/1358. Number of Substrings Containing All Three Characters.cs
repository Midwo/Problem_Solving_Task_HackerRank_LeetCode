using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1358
    {
        ////(1358.) Number of Substrings Containing All Three Characters (MEDIUM)
        public int NumberOfSubstrings(string s)
        {
            ////Solution 1
            int countCorrectSubstrings = 0;
            int lenght = s.Length;

            int[] indexCharABC = [-1,-1,-1];

            for (int index = 0; index < lenght; index++)
            {
                indexCharABC[s[index] - 'a'] = index;

                if(indexCharABC[0] > -1 && indexCharABC[1] > -1 && indexCharABC[2] > -1)
                {
                    int minIndex = Math.Min(indexCharABC[0], Math.Min(indexCharABC[1], indexCharABC[2]));

                    countCorrectSubstrings += minIndex+1;
                }

            }

            return countCorrectSubstrings;

            ////Solution 2
            //int countCorrectSubstrings = 0;
            //int lenght = s.Length;

            //for (int indexStart = 0; indexStart < lenght-2; indexStart++)
            //{
            //    bool charA = false;
            //    bool charB = false;
            //    bool charC = false;

            //    for (int index = indexStart; index < lenght; index++)
            //    {
            //        int currChar = s[index];

            //        if (currChar == 'a')
            //            charA = true;
            //        else if (currChar == 'b')
            //            charB = true;
            //        else
            //            charC = true;

            //        if(charA && charB && charC)
            //        {
            //            countCorrectSubstrings += lenght - index;
            //            break;
            //        }
            //    }

            //    if (!charA || !charB || !charC)
            //        break;
            //}

            //return countCorrectSubstrings;
        }
    }
}

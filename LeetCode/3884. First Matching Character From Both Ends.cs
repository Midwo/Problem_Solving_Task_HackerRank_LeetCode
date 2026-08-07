using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3884
    {
        ////(3884.) First Matching Character From Both Ends (EASY)
        public int FirstMatchingIndex(string s)
        {
            int length = s.Length;

            for (int index = 0; index < length; index++)
            {
                int currChar = s[index];

                int seachrIndex = length - index - 1;
                if(seachrIndex >= 0 && seachrIndex < length && currChar == s[seachrIndex])
                    return index;
            }

            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1461
    {
        ////(1461.) Check If a String Contains All Binary Codes of Size K (MEDIUM)
        public bool HasAllCodes(string s, int k)
        {
            HashSet<string> uniqueStringsKLength = new HashSet<string>();

            int howManyReq = (int)Math.Pow(2, k);

            if (s.Length + 1 - k < howManyReq) return false;

            for (int i = 0; i < s.Length -  k+1; i++)
            {
                uniqueStringsKLength.Add(s[i..(i+k)]);
            }

            if (uniqueStringsKLength.Count == howManyReq)
            {
                return true;
            }

            return false;
        }
    }
}

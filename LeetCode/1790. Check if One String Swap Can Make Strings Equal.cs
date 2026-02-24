using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1790
    {
        ////(1790.) Check if One String Swap Can Make Strings Equal (EASY)
        public bool AreAlmostEqual(string s1, string s2)
        {
            List<char[]> listSwap  = new List<char[]>();
            for (int index = 0; index < s1.Length; index++)
            {
                if (s1[index] != s2[index])
                {
                    listSwap.Add(new char[] { s1[index], s2[index] });
                    if(listSwap.Count > 2)
                    {
                        return false;
                    }
                }
            }

            if (listSwap.Count == 0)
            {
                return true;
            }
            else if (listSwap.Count < 2)
            {
                return false;
            }

            if (listSwap[0][0] == listSwap[1][1] && listSwap[1][0] == listSwap[0][1])
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2840
    {
        ////(2840.) Check if Strings Can be Made Equal With Operations II (MEDIUM)
        public bool CheckStrings(string s1, string s2)
        {
            int[] countCharIndexEven = new int[26];
            int[] countCharIndexOdd = new int[26];

            int length = s1.Length;

            for (int index = 0; index < length; index++)
            {
                if (index % 2 == 0)
                {
                    countCharIndexEven[s1[index] - 'a']++;
                    countCharIndexEven[s2[index] - 'a']--;
                }
                else
                {
                    countCharIndexOdd[s1[index] - 'a']++;
                    countCharIndexOdd[s2[index] - 'a']--;
                }
            }

            for (int index = 0; index < 26; index++)
            {
                if (countCharIndexEven[index] != 0 || countCharIndexOdd[index] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

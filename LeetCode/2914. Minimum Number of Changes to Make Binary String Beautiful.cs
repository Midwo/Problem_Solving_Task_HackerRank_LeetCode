using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2914
    {
        ////(2914.) Minimum Number of Changes to Make Binary String Beautiful (MEDIUM)
        public int MinChanges(string s)
        {
            int countChanges = 0;

            for (int index = 1; index < s.Length; index += 2)
            {
                if (s[index - 1] != s[index])
                    countChanges++;
            }

            return countChanges;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3014
    {
        ////(3014.) Minimum Number of Pushes to Type Word I (EASY)
        public int MinimumPushes(string word)
        {
            int length = word.Length;

            if (length > 24)
                return 48 + (length - 24) * 4;
            if (length > 16)
                return 24 + (length - 16) * 3;
            if (length > 8)
                return 8 + (length - 8) * 2;

            return length;
        }
    }
}

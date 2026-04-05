using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2027
    {
        ////(2027.) Minimum Moves to Convert String (EASY)
        public int MinimumMoves(string s)
        {
            int minimumMoves = 0;

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] == 'X')
                {
                    minimumMoves++;
                    index += 2;
                }
            }

            return minimumMoves;
        }
    }
}

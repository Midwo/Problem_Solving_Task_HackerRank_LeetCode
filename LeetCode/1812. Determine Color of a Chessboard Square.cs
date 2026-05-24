using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1812
    {
        ////(1812.) Determine Color of a Chessboard Square (EASY)
        public bool SquareIsWhite(string coordinates)
        {
            if ((coordinates[0] - 'a') % 2 == 0)
            {
                if ((coordinates[1] - '1') % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if ((coordinates[1] - '1') % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

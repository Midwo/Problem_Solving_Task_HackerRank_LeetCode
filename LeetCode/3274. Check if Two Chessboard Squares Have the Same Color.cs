using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3274
    {
        ////(3274.) Check if Two Chessboard Squares Have the Same Color (EASY)
        public bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            ////51ms, Beats: 91.18%
            
            if (Math.Abs(coordinate1[0] - coordinate2[0]) % 2 == 0)
            {
                if (Math.Abs(coordinate1[1] - coordinate2[1]) % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (Math.Abs(coordinate1[1] - coordinate2[1]) % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}

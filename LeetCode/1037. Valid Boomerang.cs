using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1037
    {
        ////(1037.) Valid Boomerang (EASY)
        public bool IsBoomerang(int[][] points)
        {
            if (points[0][0] * (points[1][1] - points[2][1]) + points[1][0] * (points[2][1] - points[0][1]) + points[2][0] * (points[0][1] - points[1][1]) != 0)
            {
                return true;
            }

            return false;
        }
    }
}

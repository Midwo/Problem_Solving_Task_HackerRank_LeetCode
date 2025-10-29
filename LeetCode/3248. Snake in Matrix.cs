using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3248
    {
        ////(3248.) Snake in Matrix (EASY)
        public int FinalPositionOfSnake(int n, IList<string> commands)
        {
            ////0ms, Beats: 100.00%

            int x = 0;
            int y = 0;

            foreach (var item in commands)
            {
                switch (item)
                {
                    case "UP":
                        y--;
                        break;
                    case "DOWN":
                        y++;
                        break;
                    case "LEFT":
                        x--;
                        break;
                    case "RIGHT":
                        x++;
                        break;
                }
            }

            return (y*n)+x;
        }
    }
}

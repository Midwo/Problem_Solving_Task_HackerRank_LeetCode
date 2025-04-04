using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_657
    {
        ////(657.) Robot Return to Origin(EASY)
        public bool JudgeCircle(string moves)
        {
            int leftRight = 0;
            int topBottom = 0;
            foreach (char currChar in moves) 
            {
                switch (currChar)
                {
                    case 'U':
                        topBottom++;
                        break;
                    case 'D':
                        topBottom--;
                        break;
                    case 'R':
                        leftRight++;
                        break;
                    case 'L':
                        topBottom--;
                        break;
                }
            }
            if (leftRight == 0 && topBottom == 0) 
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

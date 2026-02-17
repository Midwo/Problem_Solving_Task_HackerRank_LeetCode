using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2833
    {
        ////(2833.) Furthest Point From Origin (EASY)
        public int FurthestDistanceFromOrigin(string moves)
        {
            int countL = 0;
            int countR = 0;
            int countFloor = 0;

            foreach (char currChar in moves)
            {
                if (currChar == 'L')
                {
                    countL++;
                }
                else if (currChar == 'R')
                {
                    countR++;
                }
                else
                {
                    countFloor++;
                }
            }

            if (countL > countR)
            {
                return countL - countR + countFloor;
            }
            else
            {
                return countR - countL + countFloor;
            }
        }
    }
}

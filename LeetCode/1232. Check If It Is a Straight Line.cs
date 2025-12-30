using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1232
    {
        ////(1232.) Check If It Is a Straight Line (EASY)
        public bool CheckStraightLine(int[][] coordinates)
        {
            int length = coordinates.Length;
            decimal a;

            if (length == 2)
            {
                return true;
            }

            int firstX = coordinates[0][0];
            int secondX = coordinates[1][0];
            int firstY = coordinates[0][1];
            int secondY = coordinates[1][1];
            bool isItHorizontal = false;
            int ay = secondY - firstY;
            int ax = secondX - firstX;

            if(ay == 0 || ax == 0)
            {
                a = 0;
                if (ax == 0) { isItHorizontal = true; }
            }
            else 
            { 
               a = (decimal)ay / ax; 
            }
            
            decimal b = firstY - (a * firstX);

            for (int i = 2; i < length; i++)
            {
                int x = coordinates[i][0];
                int y = coordinates[i][1];

                if (a == 0)
                {
                    if (isItHorizontal)
                    {
                        if(firstX == x)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if(firstY == y)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (y != (a * x) + b)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

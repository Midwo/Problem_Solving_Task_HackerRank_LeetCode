using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0037
    {
        ////37. Number Line Jumps (EASY)
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            string message = "NO";
            if (x1 > x2 && v1 > v2)
            {
                message = "NO";
            }
            else if (x2 > x1 && v2 > v1)
            {
                message = "NO";
            }
            if (x1 + v1 > x2 + v2)
            {
                do
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2)
                    {
                        message = "YES";
                    }
                }
                while (x1 > x2);
            }
            else if (x2 + v2 > x1 + v1)
            {
                do
                {
                    x1 += v1;
                    x2 += v2;
                    if (x2 == x1)
                    {
                        message = "YES";
                    }
                }
                while (x2 > x1);
            }
            else
            {
                message = "YES";
            }

            return message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0003
    {
        public string catAndMouse(int x, int y, int z)
        {
            int CatA = Math.Abs(z - x);
            int CatB = Math.Abs(z - y);

            if (CatA == CatB)
            {
                return "Mouse C";
            }
            else if (CatA < CatB)
            {
                return "Cat A";
            }
            else
            {
                return "Cat B";
            }
        }
    }
}

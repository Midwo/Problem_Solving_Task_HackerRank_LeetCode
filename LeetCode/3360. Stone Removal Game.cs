using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3360
    {
        ////(3360.) Stone Removal Game (EASY)
        public bool CanAliceWin(int n)
        {
            int howManyRemove = 10;
            bool aliceWin = false;

            while (n >= howManyRemove)
            {
                n -= howManyRemove--;

                aliceWin = aliceWin == false ? true : false;
            }

            return aliceWin;
        }
    }
}

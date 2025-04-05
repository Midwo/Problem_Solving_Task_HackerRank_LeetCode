using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_693
    {
        ////(693.) Binary Number with Alternating Bits (EASY)
        public bool HasAlternatingBits(int n)
        {
            string x = Convert.ToString(n,2);
            char target = x[0];

            for (int i = 1; i<x.Length; i++)
            {
                if (x[i] == target)
                {
                    return false;
                }
                else
                {
                    target = x[i];
                }
            }

            return true;
        }
    }
}

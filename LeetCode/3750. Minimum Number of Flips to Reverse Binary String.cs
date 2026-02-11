using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3750
    {
        ////(3750.) Minimum Number of Flips to Reverse Binary String (EASY)
        public int MinimumFlips(int n)
        {
            string nBinaryRepresentation = Convert.ToString(n, 2);
            int miniumFlips = 0;
            int lenght = nBinaryRepresentation.Length;

            for (int i = 0; i < lenght; i++) 
            { 
                if (nBinaryRepresentation[i] != nBinaryRepresentation[lenght - 1 - i])
                {
                    miniumFlips++;
                }
            }

            return miniumFlips;
        }
    }
}

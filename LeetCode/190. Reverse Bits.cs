using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_190
    {
        ////(190.) Reverse Bits (EASY)
        public int ReverseBits(int n)
        {
            uint newN = (uint)n;
            string tempString = Convert.ToString(newN, 2).PadLeft(32, '0');
            string newReverseString = string.Empty;
            for (int i = tempString.Length - 1; i >= 0; i--)
            {
                newReverseString += tempString[i];
            }
            return Convert.ToInt32(newReverseString, 2);
        }
    }
}

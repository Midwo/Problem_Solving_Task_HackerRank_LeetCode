using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4030
    {
        ////(4030.) Check ASCII Palindromic (EASY)
        public bool IsPalindromic(string s)
        {
            int length = s.Length;

            for (int index = 0; index < length / 2; index++)
            {
                string left = Convert.ToString(s[index], 2).PadLeft(8, '0');
                string right = Convert.ToString(s[length - 1 - index], 2).PadLeft(8, '0');

                for (int index2 = 0; index2 < 8; index2++)
                {
                    if (left[index2] != right[7 - index2])
                    {
                        return false;
                    }
                }
            }

            if (length % 2 == 1)
            {
                string binaryRepresentation = Convert.ToString(s[length/2], 2).PadLeft(8, '0');
  
                for (int index2 = 0; index2 < 4; index2++)
                {
                    if (binaryRepresentation[index2] != binaryRepresentation[7 - index2])
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_717
    {
        ////(717.) 1-bit and 2-bit Characters (EASY)
        public bool IsOneBitCharacter(int[] bits)
        {
            int lenght = bits.Length-1;

            if (bits[lenght] == 1)
            {
                return false;
            }
            int howManyRest = lenght;
           
            for (int i = 0; i < lenght; i++)
            {
                if (bits[i] == 1)
                {
                    i++;
                    if (i == lenght)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

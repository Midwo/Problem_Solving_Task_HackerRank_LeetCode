using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2683
    {
        ////(2683.) Neighboring Bitwise XOR (MEDIUM)
        public bool DoesValidArrayExist(int[] derived)
        {
            int length = derived.Length;
            int[] originalTable = new int[length+1];
            originalTable[0] = 0;

            for (int i = 0; i < length; i++)
            {
                originalTable[i+1] = originalTable[i]  ^ derived [i];
            }

            bool checkZero = originalTable[0] == originalTable[length];

            originalTable[0] = 1;
            
            for (int i = 0; i < length; i++)
            {
                originalTable[i + 1] = originalTable[i] ^ derived[i];
            }

            bool checkOne = originalTable[0] == originalTable[length];

            return checkZero || checkOne;
        }
    }
}

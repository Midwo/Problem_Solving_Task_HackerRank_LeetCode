using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1720
    {
        ////(1720.) Decode XORed Array (EASY)
        public int[] Decode(int[] encoded, int first)
        {
            int[] decode = new int[encoded.Length+1];
            decode[0] = first;
            
            for (int i = 0; i < encoded.Length; i++)
            {
                decode[i+1] = encoded[i] ^ decode[i];
            }

            return decode;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2433
    {
        ////(2433.) Find The Original Array of Prefix Xor (MEDIUM)
        public int[] FindArray(int[] pref)
        {
            int[] result = new int[pref.Length];
            result[0] = pref[0];

            for (int i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i - 1];
            }

            return result;
        }
    }
}

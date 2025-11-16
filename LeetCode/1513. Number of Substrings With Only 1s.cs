using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1513
    {
        ////(1513.) Number of Substrings With Only 1s (MEDIUM)
        public int NumSub(string s)
        {
            int mod = 1000000007;
            long result = 0;
            long currCountOne = 0;
            
            foreach (char c in s) 
            { 
                if(c == '1')
                {
                    currCountOne++;
                }
                else if(c == '0' && currCountOne > 0)
                {
                    result = ((currCountOne + 1) * currCountOne / 2+result) % mod;

                    currCountOne = 0;
                }            
            }

            if (currCountOne > 0) 
            { 
                result = ((currCountOne + 1) * currCountOne / 2 + result) % mod;
            }

            return (int)result;
        }
    }
}

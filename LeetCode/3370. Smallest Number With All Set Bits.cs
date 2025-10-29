using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3370
    {
        ////(3370.) Smallest Number With All Set Bits (EASY)    
        public int SmallestNumber(int n)
        {
            ////0ms, Beats: 100.00%

            //string nStringBits = Convert.ToString(n, 2);
            int result = 0;
            string nBits =  Convert.ToString(n, 2);

            for (int i = 0; i < nBits.Length; i++)
            {
                result += (int)Math.Pow(2, i);
            }

            return result;
        }
    }
}

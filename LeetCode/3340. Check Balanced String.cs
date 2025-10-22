using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3340
    {
        ////(3340.) Check Balanced String (EASY)
        public bool IsBalanced(string num)
        {
            ////0ms, Beats: 100.00%
            
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < num.Length; i++) 
            { 
                if(i % 2 == 1)
                {
                    sumOdd += (int)num[i] - '0';
                }
                else
                {
                    sumEven += (int)num[i] - '0';
                }
            }
            
            return sumEven == sumOdd? true: false;
        }
    }
}

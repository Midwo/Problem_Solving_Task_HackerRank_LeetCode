using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1903
    {
        ////(1903.) Largest Odd Number in String (EASY)
        public string LargestOddNumber(string num)
        {
            int length = num.Length;

            for (int i = length - 1; i > -1; i--) 
            { 
                if (((num[i] - '0') & 1) == 1)
                {
                    return num[0..(i + 1)];
                }
            }
            return "";
        }
    }
}

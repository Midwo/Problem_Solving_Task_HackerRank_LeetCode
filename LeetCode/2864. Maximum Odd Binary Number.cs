using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2864
    {
        ////(2864.) Maximum Odd Binary Number (EASY)
        public string MaximumOddBinaryNumber(string s)
        {
            int countOne = -1;
            int countZero = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++) 
            { 
                if (s[i] == '0')
                {
                    countZero++;
                }
                else
                {
                    countOne++;
                }
            }

            for (int i = 0; i < countOne; i++) 
            {
                sb.Append('1');
            }
            for (int i = 0; i < countZero; i++)
            {
                sb.Append('0');
            }
            sb.Append('1');

            return new string(sb.ToString());
        }
    }
}

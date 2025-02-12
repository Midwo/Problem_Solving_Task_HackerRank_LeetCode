using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_405
    {
        ////(405.) Convert a Number to Hexadecimal (EASY)
        public string ToHex(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            char[] hexValues = {'0', '1', '2', '3', '4', '5', '6', '7',
            '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
            StringBuilder resultStringBuilder = new StringBuilder();

            while (num != 0)
            {
                resultStringBuilder.Append(hexValues[num & 0xf]);
                num >>>= 4;
            }
            return new string(resultStringBuilder.ToString().Reverse().ToArray());
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1009
    {
        ////(1009.) Complement of Base 10 Integer (EASY)
        public int BitwiseComplement(int n)
        {
            string convertNtoString = Convert.ToString(n, 2);
            int result = 0;

            for (int i = convertNtoString.Length-1; i>=0;  i--)
            {
                if (convertNtoString[i] == '0')
                {
                    result += (int)Math.Pow(2, convertNtoString.Length - 1-i);
                }
            }

            return result;
        }
    }
}

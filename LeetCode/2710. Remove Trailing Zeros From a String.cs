using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2710
    {
        public string RemoveTrailingZeros(string num)
        {
            int indexFirstZero = -1;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == '0')
                {
                    indexFirstZero = i;
                }
                else
                {
                    break;
                }
            }

            if (indexFirstZero == -1)
            {
                return num;
            }
            else
            {
                return num[0..indexFirstZero];
            }
        }
    }
}

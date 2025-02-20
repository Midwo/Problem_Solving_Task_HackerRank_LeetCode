using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_476
    {
        ////(476.) Number Complement (EASY)
        public int FindComplement(int num)
        {
            string stringByteNum = Convert.ToString(num, 2);
            int result = 0;
            for (int i = stringByteNum.Length-1; i >= 0; i--)
            {
                if (stringByteNum[i] == '0')
                {
                    result += (int)Math.Pow(2, stringByteNum.Length-1-i);
                }
            }
            return result;
        }
    }
}

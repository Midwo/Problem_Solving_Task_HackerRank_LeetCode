using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_258
    {
        ////(258.) Add Digits (EASY)
        public int AddDigits(int num)
        {
            int currNum = 0;
            string numString = num.ToString();
            if (num < 10)
            {
                return num;
            }
            while (num > 9)
            {
                for (int i = 0; i < numString.Length; i++) 
                {
                    currNum += Convert.ToInt32(numString[i].ToString());
                }
                num = currNum;
                numString = num.ToString();
                currNum = 0;
            }
            return num;
        }
    }
}

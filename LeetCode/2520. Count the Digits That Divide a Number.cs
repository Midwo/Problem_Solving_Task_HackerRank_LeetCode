using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2520
    {
        ////(2520.) Count the Digits That Divide a Number (EASY)
        public int CountDigits(int num)
        {
            int result = 0;
            int copyNum = num;

            while (copyNum > 0) 
            {
                if (num % (copyNum % 10) == 0)
                {
                    result++;
                }
                copyNum /= 10;
            }

            return result;
        }
    }
}

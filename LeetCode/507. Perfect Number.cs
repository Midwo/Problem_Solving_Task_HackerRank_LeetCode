using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_507
    {
        ////(507.) Perfect Number (EASY)
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 2) 
            {
                return false;
            }
            int result = 0;
            if (num % 2 == 0)
            {
                for (int i = 1; i <= num/2; i++) 
                {
                    if (num % i == 0)
                    {
                        result += i;
                        if (result > num)
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            if (result == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

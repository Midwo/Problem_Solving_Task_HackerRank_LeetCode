using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2169
    {
        ////(2169.) Count Operations to Obtain Zero (EASY)
        public int CountOperations(int num1, int num2)
        {
            int count = 0;
            
            while (num1 != 0 && num2 != 0)
            {
                if (num1 < num2)
                {
                    count++;
                    num2 = num2 - num1;
                }
                else if (num1 > num2)
                {
                    num1 = num1 - num2;
                    count++;
                }
                else
                {
                    count++;
                    break;
                }
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1317
    {
        ////(1317.) Convert Integer to the Sum of Two No-Zero Integers (EASY)
        public int[] GetNoZeroIntegers(int n)
        {
            for (int i = 1; i <= n-1; i++)
            {
                int value = i;
                bool valueStatus = true;

                while (value != 0)
                {
                    if(value % 10 == 0)
                    {
                        valueStatus = false;
                        break;
                    }
                    else
                    {
                        value = value/10;
                    }
                }
                if (valueStatus)
                {
                    value = n - i;
                    while (value != 0)
                    {
                        if (value % 10 == 0)
                        {
                            valueStatus = false;
                            break;
                        }
                        else
                        {
                            value = value/10;
                        }
                    }

                    if (valueStatus)
                    {
                        return new int[] { i, n-i };
                    }
                }
            }
            
            return new int[2];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2595
    {
        ////(2595.) Number of Even and Odd Bits (EASY)
        public int[] EvenOddBit(int n)
        {
            int countEven = 0;
            int countOdd = 0;
            
            string nToBitsString = Convert.ToString(n, 2);
            int length = nToBitsString.Length;

            for (int i = 0; i < length; i++)
            {
                if (nToBitsString[i] == '1')
                {
                    if (i % 2 == 0)
                    {
                        countEven++;
                    }
                    else
                    {
                        countOdd++;
                    }
                }
            }

            if (length % 2 == 0)
            {
                return new int[] { countOdd, countEven };
            }

            return new int[] { countEven, countOdd };
        }
    }
}

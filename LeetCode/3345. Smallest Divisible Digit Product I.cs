using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3345
    {
        ////(3345.) Smallest Divisible Digit Product I (EASY)
        public int SmallestNumber(int n, int t)
        {
            while(n < 101)
            {
                int tempN = n;
                int productValue = 1;
                
                while(tempN!= 0)
                {
                    productValue *= tempN % 10;
                    tempN /= 10;
                }

                if(productValue % t == 0)
                {
                    return n;
                }

                n++;
            }
            return -1;
        }
    }
}

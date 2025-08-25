using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1281
    {
        ////(1281.) Subtract the Product and Sum of Digits of an Integer (EASY)
        public int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;
            int temp = int.MaxValue;

            while(n != 0)
            {
                temp = n % 10;
                n /= 10;
                sum += temp;
                product *= temp;
            }

            return product - sum;
        }
    }
}

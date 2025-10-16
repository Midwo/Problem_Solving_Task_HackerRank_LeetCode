using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3658
    {
        ////(3658.) GCD of Odd and Even Sums (EASY)
        public int GcdOfOddEvenSums(int n)
        {
            return (n * (n + 1)) - (n * n);

            //// OR
            //int sumOdd = n * n;
            //int sumEven = n * (n + 1);

            //return sumEven - sumOdd;
        }
    }
}

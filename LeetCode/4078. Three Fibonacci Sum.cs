using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4078
    {
        ////(4078.) Three Fibonacci Sum (EASY)
        public bool ThreeFibonacciSum(int n)
        {
            int first = 1;
            int second = 1;
            int third = 0;
            int sum = 1;

            while (sum < n)
            {
                first = second + third;

                sum = first + second + third;
                if (sum == n)
                    return true;

                third = second;
                second = first;
            }

            return false;
        }
    }
}

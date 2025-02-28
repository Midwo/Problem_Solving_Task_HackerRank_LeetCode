using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_509
    {
        ////(509.) Fibonacci Number (EASY)
        public int Fib(int n)
        {
            ////HARDCODE VERSION - NOT RECOMMENDATION
            //int[] result = [0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597,2584,4181,6765,10946,17711,28657,46368,75025,121393,196418,317811,514229];
            //return result[n];

            ////Alternative:
            int result = 0;
            if (n == 0) { return 0; }
            else if (n == 1) { return 1; }
            int prev = 1;
            int prevprev = 0;
            for (int i = 2; i <= n; i++)
            {
                result = prev + prevprev;
                prevprev = prev;
                prev = result;
            }
            
            return result;
        }
    }
}

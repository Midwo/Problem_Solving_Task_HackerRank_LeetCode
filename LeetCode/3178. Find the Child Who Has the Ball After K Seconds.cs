using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3178
    {
        ////(3178.) Find the Child Who Has the Ball After K Seconds (EASY)
        public int NumberOfChild(int n, int k)
        {
            int numberOfStepsForAnalysis = k % (n + n - 2);

            if (numberOfStepsForAnalysis < n)
            {
                return numberOfStepsForAnalysis;
            }
            else
            {
                return n + (n - numberOfStepsForAnalysis) - 2;
            }
        }
    }
}

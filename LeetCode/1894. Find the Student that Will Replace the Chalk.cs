using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1894
    {
        ////(1894.) Find the Student that Will Replace the Chalk (MEDIUM)
        public int ChalkReplacer(int[] chalk, int k)
        {
            long sum = 0;

            foreach (int currValue in chalk) 
            {
                sum += currValue;
            }
            int countChalk = chalk.Length;

            long rest = k % sum;

            for (int i = 0; i < chalk.Length; i++)
            {
                int currValue = chalk[i];
                if (currValue <= rest)
                {
                    rest -= currValue;
                }
                else { return i; }
            }

            return 0;
        }
    }
}

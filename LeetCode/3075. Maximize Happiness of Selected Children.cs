using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3075
    {
        ////(3075.) Maximize Happiness of Selected Children (MEDIUM)
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness);
            long sumHappiness = 0;
            int decrease = 0;

            for (int i = happiness.Length-1; i >= happiness.Length -k; i--)
            {
                int currHappiness = happiness[i] - decrease++;
                if (currHappiness <= 0)
                    break;
                sumHappiness += currHappiness;
            }

            return sumHappiness;
        }
    }
}

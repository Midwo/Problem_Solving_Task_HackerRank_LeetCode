using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1387
    {
        ////(1387.) Sort Integers by The Power Value (MEDIUM)
        public int GetKth(int lo, int hi, int k)
        {
            int length = hi - lo + 1;
            int[][] tableValueAndPowerValue = new int[length][];

            for (int addValue = 0; addValue < length; addValue++)
            {
                int currValue = lo + addValue;
                int countOperations = 0;

                while(currValue != 1)
                {
                    if(currValue % 2 == 0)
                    {
                        currValue = currValue / 2;
                    }
                    else
                    {
                        currValue = 3 * currValue + 1;
                    }
                    countOperations++;
                }

                tableValueAndPowerValue[addValue] = new int[] { (lo+addValue), countOperations };
            }

            tableValueAndPowerValue = tableValueAndPowerValue.OrderBy(x => x[1]).ToArray();

            return tableValueAndPowerValue[k-1][0];
        }
    }
}

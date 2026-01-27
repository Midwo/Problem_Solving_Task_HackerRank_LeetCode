using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1447
    {
        ////(1447.) Simplified Fractions (MEDIUM)
        public IList<string> SimplifiedFractions(int n)
        {
            IList<string> resultList = new List<string>();

            for (int firstValue = 1; firstValue < n; firstValue++)
            {
                for (int secondValue = firstValue+1; secondValue <= n; secondValue++)
                {
                    if (GCDScore(firstValue, secondValue) == 1)
                    {
                        resultList.Add(string.Concat(firstValue, '/', secondValue));
                    }
                }
            }

            return resultList;
        }

        private int GCDScore(int firstValue, int secondValue)
        {
            while(secondValue != 0)
            {
                int temp = firstValue % secondValue;
                firstValue = secondValue;
                secondValue = temp;
            }
            return firstValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3524
    {
        ////(3524.) Find X Value of Array I (MEDIUM)
        public long[] ResultArray(int[] nums, int k)
        {
            long[] resultArray = new long[k];
            long[] currArray = new long[k];

            foreach (var value in nums)
            {
                long[] addList = new long[k];
                for (long i = 0; i < k; i++)
                {
                    long currCount = currArray[i];
                    if (currCount > 0)
                    {
                        addList[(i * value) % k] += currCount;
                    }
                }

                for (long i = 0; i < k; i++)
                {
                    resultArray[i] += addList[i];
                }
                resultArray[value % k]++;
                addList[value % k]++;

                currArray = addList;
            }

            return resultArray;
        }
    }
}

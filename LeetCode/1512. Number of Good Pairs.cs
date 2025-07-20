using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1512
    {
        ////(1512.) Number of Good Pairs (EASY)
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> countNumbersDictionary = new Dictionary<int, int>();
            int result = 0;

            foreach (int i in nums)
            {
                if (countNumbersDictionary.ContainsKey(i))
                {
                    countNumbersDictionary[i]++;
                }
                else
                {
                    countNumbersDictionary.Add(i, 1);
                }
            }

            foreach (int i in countNumbersDictionary.Values)
            {
                if (i > 1)
                {
                    result += i * (i - 1) / 2;
                }
            }

            return result;

        }
    }
}

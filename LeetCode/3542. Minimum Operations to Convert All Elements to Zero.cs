using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3542
    {
        ////(3542.) Minimum Operations to Convert All Elements to Zero (MEDIUM)
        public int MinOperations(int[] nums)
        {
            int countOperation = 0;
            List<int> listFromNums = new List<int>();

            foreach (int num in nums)
            {
                while (listFromNums.Count > 0 && num < listFromNums[listFromNums.Count - 1])
                {
                    listFromNums.RemoveAt(listFromNums.Count - 1);
                }

                if (num == 0)
                {
                    continue;
                }

                else if (listFromNums.Count == 0 || listFromNums[listFromNums.Count - 1] < num)
                {
                    countOperation++;
                    listFromNums.Add(num);
                }
            }
            return countOperation;
        }
    }
}

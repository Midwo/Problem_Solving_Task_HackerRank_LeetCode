using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2869
    {
        ////(2869.) Minimum Operations to Collect Elements (EASY)
        public int MinOperations(IList<int> nums, int k)
        {
            bool[] valueStatus = new bool[k+1];
            int countTrueValueStatus = 0;
            int lenght = nums.Count;
            int indexNums = lenght - 1;
            int currValue = 0;

            while(countTrueValueStatus != k)
            {
                currValue = nums[indexNums--];
                if (currValue <= k && !valueStatus[currValue])
                {
                    countTrueValueStatus++;
                    valueStatus[currValue] = true;
                }
            }

            return lenght - indexNums-1;
        }
    }
}

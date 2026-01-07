using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2164
    {
        ////(2164.) Sort Even and Odd Indices Independently (EASY)
        public int[] SortEvenOdd(int[] nums)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            int length = nums.Length;
            int currValue;

            for (int indexNums = 0; indexNums < length; indexNums++)
            {
                currValue = nums[indexNums];
                if ((indexNums & 1) == 1)
                {
                    oddList.Add(currValue);
                }
                else
                {
                    evenList.Add(currValue);
                }
            }

            evenList.Sort();
            oddList.Sort();
            oddList.Reverse();

            int indexList = 0;
            for (int indexNums = 0; indexNums < length; indexNums++)
            {
                if ((indexNums & 1) == 0)
                {
                    nums[indexNums] = evenList[indexList];
                }
                else
                {
                    nums[indexNums] = oddList[indexList++];
                }
            }

            return nums;
        }
    }
}

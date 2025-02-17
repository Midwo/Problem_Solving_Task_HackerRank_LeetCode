using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_448
    {
        ////(448.) Find All Numbers Disappeared in an Array (EASY)
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> result = new List<int>();

            Array.Sort(nums);
            int howManyDubels = 0;
            int howManyAddValues = 0;
            int numsLenght = nums.Length;
            if (nums[0] != 1)
            {
                for (int i = 1; i < nums[0]; i++)
                {
                    howManyAddValues++;
                    result.Add(i);
                }
            }
            for (int i = 1; i < numsLenght; i++)
            {
                int numsCurr = nums[i];
                int numsMinusOne = nums[i - 1];
                if (numsCurr == nums[i - 1])
                {
                    howManyDubels++;
                }
                else if (numsMinusOne != numsCurr - 1)
                {
                    for (int j = numsMinusOne + 1; j < numsCurr; j++)
                    {
                        result.Add(j);
                        howManyAddValues++;
                    }
                }
            }
            int tempLastValue = nums[numsLenght - 1];
            while (howManyDubels > howManyAddValues)
            {
                result.Add(tempLastValue++ + 1);
                howManyAddValues++;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2442
    {
        ////(2442.) Count Number of Distinct Integers After Reverse Operations (MEDIUM)
        public int CountDistinctIntegers(int[] nums)
        {
            HashSet<int> numsList = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                numsList.Add(currValue);

                int reverceValue = 0;
                while(currValue != 0)
                {
                    int tempModulo = currValue % 10;
                    reverceValue = reverceValue * 10 + tempModulo;
                    currValue /= 10;
                }
                numsList.Add(reverceValue);
            }

            return numsList.Count;
        }
    }
}

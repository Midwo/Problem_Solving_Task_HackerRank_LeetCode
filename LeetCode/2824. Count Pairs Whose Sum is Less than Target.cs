using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2824
    {
        ////(2824.) Count Pairs Whose Sum is Less than Target (EASY)
        public int CountPairs(IList<int> nums, int target)
        {
            int leftIndex = 0;
            int rightIndex = nums.Count-1;
            int result = 0;

            int[] arrayInt = nums.ToArray();
            Array.Sort(arrayInt);

            while(leftIndex != rightIndex)
            {
                if(arrayInt[leftIndex] + arrayInt[rightIndex] < target)
                {
                    result += Math.Abs(rightIndex-leftIndex);
                    leftIndex++;
                }
                else
                {
                    rightIndex--;    
                }
            }


            return result;
        }
    }
}

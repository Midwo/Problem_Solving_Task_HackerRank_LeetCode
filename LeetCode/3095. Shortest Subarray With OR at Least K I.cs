using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3095
    {
        ////(3095.) Shortest Subarray With OR at Least K I   (EASY)
        public int MinimumSubarrayLength(int[] nums, int k)
        {
            int minLenght = int.MaxValue;
            int numsLenght = nums.Length;

            for (int indexStart = 0; indexStart < numsLenght; indexStart++)
            {
                int currLenght = 1;
                int currOR = nums[indexStart];
                if (currOR >= k)
                    return 1;
                for (int currIndex = indexStart+1; currIndex < numsLenght; currIndex++)
                {
                    currOR |= nums[currIndex];

                    if(currOR >= k)
                    {
                        currLenght = currIndex - indexStart+1;
                        break;
                    }
                }
                if (currOR >= k)
                    minLenght = minLenght > currLenght ? currLenght : minLenght;
                else
                    break;
            } 

            return minLenght == int.MaxValue ? -1 : minLenght;
        }
    }
}

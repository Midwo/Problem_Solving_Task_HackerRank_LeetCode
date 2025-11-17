using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3432
    {
        ////(3432.) Count Partitions with Even Sum Difference (EASY)
        public int CountPartitions(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int resultCountEven = 0;

            for (int i = 0; i < nums.Length; i++) 
            { 
                rightSum += nums[i];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];
                rightSum -= temp;
                leftSum += temp;
                if ((leftSum - rightSum)%2 == 0)
                {
                    resultCountEven++;
                }
            }

            return resultCountEven;
        }
    }
}

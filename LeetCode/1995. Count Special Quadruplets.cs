using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1995
    {
        ////(1995.) Count Special Quadruplets (EASY)
        public int CountQuadruplets(int[] nums)
        {
            int length = nums.Length;
            int[] numsMaxValueReverse = new int[length];
            int currMax = -1;

            for (int index = length - 1; index >= 0; index--) 
            {
                currMax = Math.Max(currMax, nums[index]);
                numsMaxValueReverse[index] = currMax;
            }

            int howManyQuadruplets = 0;

            for (int index1 = 0; index1 < length - 3; index1++) 
            {
                int currValue1 = nums[index1];
                if (currValue1 > numsMaxValueReverse[index1+1])
                {
                    continue;
                }
                for (int index2 = index1 + 1; index2 < length - 2; index2++)
                { 
                    int currValue2 = nums[index2];
                    if (currValue1 + currValue2 > numsMaxValueReverse[index2 + 1])
                    {
                        continue;
                    }
                    for (int index3 = index2+1; index3 < length -1; index3++)
                    {
                        int currValue3 = nums[index3];
                        int sum = currValue1 + currValue2 + currValue3;
                        if (sum > numsMaxValueReverse[index3 + 1])
                        {
                            continue;
                        }
                        for(int index4 = index3+1; index4 < length; index4++)
                        {
                            if(sum == nums[index4])
                            {
                                howManyQuadruplets++;
                            }                            
                        }
                    }
                } 
            }

            return howManyQuadruplets;
        }
    }
}

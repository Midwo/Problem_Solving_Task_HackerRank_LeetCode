using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2717
    {
        ////(2717.) Semi-Ordered Permutation (EASY)
        public int SemiOrderedPermutation(int[] nums)
        {
            int length = nums.Length;

            if (nums[0] == 1 && nums[length - 1] == length)
            {
                return 0;
            }
            if (nums[0] == 1)
            {
                int indexTarget = 1;
                while (indexTarget < length - 1)
                {
                    if (nums[indexTarget] == length)
                    {
                        return length - 1 - indexTarget;
                    }
                    indexTarget++;
                }
            }
            if (nums[length - 1] == length)
            {
                int indexTarget = 1;
                while (indexTarget < length - 1)
                {
                    if (nums[indexTarget] == 1)
                    {
                        return indexTarget;
                    }
                    indexTarget++;
                }
            }

            int index = 0;
            int firstValueIndex = 0;
            int lastValueIndex = 0;
            while (index < length)
            {
                if (nums[index] == 1)
                {
                    firstValueIndex = index;
                }
                else if (nums[index] == length)
                {
                    lastValueIndex = index;
                }
                if (firstValueIndex > 0 && lastValueIndex > 0)
                {
                    break;
                }
                index++;
            }

            if (firstValueIndex < lastValueIndex)
            {
                return firstValueIndex + length - 1 - lastValueIndex;
            }
            else
            {
                if (lastValueIndex+1 == length - 1)
                {
                    return firstValueIndex;
                }
                return firstValueIndex + length - 1 - lastValueIndex -1;
            }
        }
    }
}

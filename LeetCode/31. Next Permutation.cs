using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_31
    {
        ////(31.) Next Permutation (MEDIUM)
        public void NextPermutation(int[] nums)
        {
            int countNums = nums.Length;
            bool noChanges = true;
            if (countNums > 1)
            {
                int lastIndexValue = nums.Length - 1;

                int maxValue = nums[lastIndexValue];
                int indexMaxValue = lastIndexValue;

                int minValue = nums[lastIndexValue];
                int indexMinValue = lastIndexValue;
                int howManyNoChanges = 0;
                bool newMinValue = false;
                bool none = false;

                for (int i = lastIndexValue - 1; i >= 0; i--)
                {
                    if (nums[i + 1] > nums[i])
                    {
                        if (nums[i + 1] >= maxValue)
                        {
                            maxValue = nums[i + 1];
                            indexMaxValue = i + 1;
                            for (int j = lastIndexValue; j >= i; j--)
                            {
                                if (nums[i] < nums[j])
                                {
                                    if (nums[j] <= maxValue)
                                    {
                                        minValue = nums[j];
                                        indexMaxValue = j;
                                        none = true;
                                    }
                                }
                            }
                        }
                        noChanges = false;
                        if (howManyNoChanges > 0 && none)
                        {
                            for (int j = lastIndexValue; j >= i; j--)
                            {
                                if (nums[i] < nums[j])
                                {
                                    if (nums[j] <= minValue)
                                    {
                                        minValue = nums[j];
                                        indexMinValue = j;
                                        newMinValue = true;
                                    }
                                }
                            }
                            if (newMinValue)
                            {
                                nums[indexMinValue] = nums[i];
                                nums[i] = minValue;
                                Array.Sort(nums, i + 1, lastIndexValue - i);
                                break;
                            }
                        }
                        nums[indexMaxValue] = nums[i];
                        nums[i] = maxValue;
                        Array.Sort(nums, i + 1, countNums - (i + 1));
                        break;
                    }
                    else
                    {
                        howManyNoChanges++;
                    }
                }
                if (noChanges)
                {
                    Array.Sort(nums);
                }
                Console.WriteLine(string.Join(',', nums));
            }
        }
    }
}

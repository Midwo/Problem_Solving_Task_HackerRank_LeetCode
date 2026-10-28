using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_75
    {
        ////(75.) Sort Colors (MEDIUM)
        public void SortColors(int[] nums)
        {
            int length = nums.Length;

            for (int index = 1; index < length; index++)
            {
                //Solution 1 Better

                int currColor = nums[index];
                if (currColor < nums[index - 1])
                {
                    int newIndex = index - 1;
                    while(newIndex >= 0 && nums[newIndex] > currColor)
                    {
                        nums[newIndex + 1] = nums[newIndex];

                        newIndex--;
                    }
                    
                    nums[newIndex+1] = currColor;


                    ////Solution 2 Worst
                    
                    //for (int currIndex = 0; currIndex <= index; currIndex++)
                    //{
                    //    if (nums[currIndex] > currColor)
                    //    {
                    //        int temp = nums[currIndex];
                    //        nums[currIndex] = currColor;

                    //        for (int currIndex2 = currIndex + 1; currIndex2 <= index; currIndex2++)
                    //        {
                    //            int currTemp = nums[currIndex2];
                    //            nums[currIndex2] = temp;
                    //            temp = currTemp;
                    //        }
                    //        break;
                    //    }
                    //}
                }
            }

            Console.WriteLine(string.Join(',', nums));
        }
    }
}

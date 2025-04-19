using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_896
    {
        ////(896.) Monotonic Array (EASY)
        public bool IsMonotonic(int[] nums)
        {
            bool decreasing = false;
            bool trendSetting = false;
            int previousValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int currNums = nums[i];
                if (!trendSetting)
                {
                    if (previousValue > currNums)
                    {
                        trendSetting = true;
                        decreasing = false;
                    }
                    else if (previousValue < currNums)
                    {
                        trendSetting = true;
                        decreasing = true;
                    }
                }
                else
                {
                    if (previousValue > currNums)
                    {
                        if (decreasing == true)
                        {
                            return false;
                        }
                    }
                    else if (previousValue < currNums)
                    {
                        if (decreasing == false)
                        {
                            return false;
                        }
                    }
                }
                previousValue = nums[i];
            }

            return true;
        }
    }
}

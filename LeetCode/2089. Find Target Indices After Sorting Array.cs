using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2089
    {
        ////(2089.) Find Target Indices After Sorting Array (EASY)
        public IList<int> TargetIndices(int[] nums, int target)
        {
            ////0ms, Beats: 100.00%

            int countTarget = 0;
            int countLessValue = 0;

            for (int i = 0; i < nums.Length; i++) 
            { 
                if (nums[i] < target)
                {
                    countLessValue++;
                }
                else if (nums[i] == target)
                {
                    countTarget++;
                }
            }

            int[] result = new int[countTarget];
            
            for (int i = countLessValue; i < countLessValue+countTarget; i++) 
            { 
                result[i- countLessValue] = i;
            }
            return result.ToList();
        }
    }
}

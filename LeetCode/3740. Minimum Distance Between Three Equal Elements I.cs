using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3740
    {
        ////(3740.) Minimum Distance Between Three Equal Elements I (EASY)
        public int MinimumDistance(int[] nums)
        {
            int length = nums.Length;
            if (length < 3)
            {
                return -1;
            }

            Dictionary<int, List<int>> dictValueAndIndexesList = new Dictionary<int, List<int>>();

            for (int i = 0; i < length; i++) 
            {
                if (dictValueAndIndexesList.ContainsKey(nums[i]))
                {
                    dictValueAndIndexesList[nums[i]].Add(i);
                }
                else
                {
                    dictValueAndIndexesList.Add(nums[i], new List<int>() { i });
                }
            }
            int minimumDistance = int.MaxValue;

            foreach (var item in dictValueAndIndexesList)
            {
                if(item.Value.Count > 2)
                {
                    for (int i = 0;i < item.Value.Count - 2; i++)
                    {
                        minimumDistance = Math.Min(minimumDistance, Math.Abs(item.Value[i] - item.Value[i + 1]) + Math.Abs(item.Value[i + 1] - item.Value[i + 2]) + Math.Abs(item.Value[i + 2] - item.Value[i]));
                    }
                }
            }
            
            if(minimumDistance == int.MaxValue)
            {
                return -1;
            }
            return minimumDistance;
        }
    }
}

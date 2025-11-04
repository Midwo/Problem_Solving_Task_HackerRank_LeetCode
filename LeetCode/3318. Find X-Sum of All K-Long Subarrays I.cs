using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3318
    {
        ////(3318.) Find X-Sum of All K-Long Subarrays I (EASY)
        public int[] FindXSum(int[] nums, int k, int x)
        {
            List<int> resultList = new List<int>();

            Dictionary<int, int> numsCount = new Dictionary<int, int>();

            for (int i = 0; i < k; i++) 
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]]++;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }
            }

            List<int[]> currList = new List<int[]>();
            foreach (var item in numsCount)
            {
                currList.Add(new int[] { item.Value, item.Key });
            }

            currList = currList.OrderByDescending(x => x[0]).ThenByDescending(x => x[1]).ToList();
            int currSum = 0;

            int copyX = x;
            if(x > currList.Count)
            {
                copyX = currList.Count;
            }
            for (int i = 0; i < copyX; i++)
            {
                currSum += currList[i][1] * currList[i][0]; 
            }
            resultList.Add(currSum);

            for (int i = k; i < nums.Length; i++)
            {
                if (numsCount.ContainsKey(nums[i]))
                {
                    numsCount[nums[i]]++;
                }
                else
                {
                    numsCount.Add(nums[i], 1);
                }

                if (numsCount[nums[i - k]] == 1)
                {
                    numsCount.Remove(nums[i - k]);
                }
                else
                {
                    numsCount[nums[i - k]]--;
                }

                currList = new List<int[]>();
                foreach (var item in numsCount)
                {
                    currList.Add(new int[] { item.Value, item.Key });
                }

                currList = currList.OrderByDescending(x => x[0]).ThenByDescending(x => x[1]).ToList();
                currSum = 0;

                copyX = x;
                if (x > currList.Count)
                {
                    copyX = currList.Count;
                }
                for (int j = 0; j < copyX; j++)
                {
                    currSum += currList[j][1] * currList[j][0];
                }
                resultList.Add(currSum);

            }
            return resultList.ToArray();
        }
    }
}

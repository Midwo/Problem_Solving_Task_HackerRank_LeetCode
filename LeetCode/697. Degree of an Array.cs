using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_697
    {
        ////(697.) Degree of an Array (EASY)
        public int FindShortestSubArray(int[] nums)
        {
            Dictionary<int, int> dictNumsCount = new Dictionary<int, int>();
            Dictionary<int, int> dictNumsFirstIndex = new Dictionary<int, int>();
            Dictionary<int, int> dictNumsLastIndex = new Dictionary<int, int>();

            int result = int.MaxValue;
            int maxCount = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictNumsCount.ContainsKey(nums[i]))
                {
                    dictNumsCount[nums[i]]++;
                    dictNumsLastIndex[nums[i]] = i;
                    maxCount = Math.Max(maxCount, dictNumsCount[nums[i]]);
                    //maxCount = maxCount < dictNumsCount[nums[i]] ? dictNumsCount[nums[i]] : maxCount;
                }
                else
                {
                    dictNumsFirstIndex.Add(nums[i], i);
                    dictNumsCount.Add(nums[i], 1);
                    dictNumsLastIndex.Add(nums[i], i);
                }
            }

            foreach (var item in dictNumsCount)
            {
                if (item.Value == maxCount)
                {
                    result = Math.Min(result, dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1);
                    //result = result > dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1? dictNumsLastIndex[item.Key] - dictNumsFirstIndex[item.Key] + 1 : result;
                }
            }

            return result;
        }
    }
}

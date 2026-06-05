using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_78
    {
        ////(78.) Subsets (MEDIUM)
        private List<IList<int>> _uniqueList = new List<IList<int>>();
        private int _lengthNums;
        public IList<IList<int>> Subsets(int[] nums)
        {
            List<int> currList = new List<int>();
            _lengthNums = nums.Length;

            GenerateLists(nums, currList, 0);

            return _uniqueList.ToList();
        }

        private void GenerateLists(int[] nums, List<int> currList, int index)
        {
            _uniqueList.Add(new List<int>(currList));
            
            for (int i = index; i < _lengthNums; ++i)
            {
                currList.Add(nums[i]);
                GenerateLists(nums, currList, i+1);
                currList.RemoveAt(currList.Count - 1);
            }
        }
    }
}

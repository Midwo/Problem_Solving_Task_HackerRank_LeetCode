using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_46
    {
        ////(46.) Permutations (MEDIUM)
        private List<IList<int>> _result;

        public IList<IList<int>> Permute(int[] nums)
        {
            _result = new List<IList<int>>();
            int length = nums.Length;
            var currList = new List<int>();
            GeneratePermutations(currList, nums, length, new bool[length]);

            return _result;
        }

        private void GeneratePermutations(List<int> currList, int[] nums, int length, bool[] visited)
        {
            if (currList.Count == length)
            {
                _result.Add(new List<int> (currList));
                return;
            }

            for (int index = 0; index < length; index++)
            {
                if (!visited[index])
                {
                    visited[index] = true;
                    currList.Add(nums[index]);
                    GeneratePermutations(currList, nums, length, visited);
                    currList.RemoveAt(currList.Count - 1);
                    visited[index] = false;
                }
            }
        }
    }
}


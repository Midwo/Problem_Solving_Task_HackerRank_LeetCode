using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_47
    {
        ////(47.) Permutations II (MEDIUM)
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> resultList = new List<IList<int>>();
            IList<int> currList = new List<int>();
            int length = nums.Length;
            bool[] statusVisited = new bool[length];

            void Gen_Permutations()
            {
                if(currList.Count == length)
                {
                    resultList.Add(new List<int> (currList));
                    return;
                }

                for (int i = 0; i < length; i++) 
                {
                    if (statusVisited[i])
                    {
                        continue;
                    }

                    if (i>0 && nums[i] == nums[i-1] && statusVisited[i - 1])
                    {
                        continue;
                    }

                    statusVisited[i] = true;
                    currList.Add(nums[i]);

                    Gen_Permutations();

                    statusVisited[i] = false;
                    currList.RemoveAt(currList.Count - 1);
                }
            }

            Gen_Permutations();

            return resultList;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_39
    {
        ////(39.) Combination Sum (MEDIUM)
        private IList<IList<int>> _uniqueListList;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            _uniqueListList = new List<IList<int>>();
            int length = candidates.Length;
            GenerationCombinationSum(candidates, target, 0, new List<int>(), 0, length);

            return _uniqueListList.ToList();
        }


        private void GenerationCombinationSum(int[] candidates, int target, int currSum, List<int> currList, int startIndex, int length)
        {
            if (currSum == target)
            {
                _uniqueListList.Add(new List<int> (currList));
                return;
            }

            for(int index = startIndex; index < length; index++) 
            {
                int candidateValue = candidates[index];
                currSum += candidateValue;
                if (currSum > target)
                {
                    currSum -= candidateValue;
                    continue;
                }

                currList.Add(candidateValue);

                GenerationCombinationSum(candidates, target, currSum, currList, index, length);

                currList.RemoveAt(currList.Count-1);
                currSum -= candidateValue;
            }            
        }
    }
}

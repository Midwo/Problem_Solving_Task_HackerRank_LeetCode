using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_216
    {
        ////(216.) Combination Sum III (MEDIUM)
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> resultCombination = new List<IList<int>>();

            Gen_CombinationTask216(new List<int>(), resultCombination, 0, k, 0, n);

            return resultCombination;
        }

        private void Gen_CombinationTask216(List<int> currList, IList<IList<int>> resultCombination, int currValue, int length, int currSum, int sum)
        {
            if (currList.Count == length && currSum == sum)
            {
                resultCombination.Add(new List<int>(currList));
                return;
            }
            else if (currList.Count == length)
            {
                return;
            }
            else if(currValue > 9)
            {
                return;
            }


            if (currValue > 0)
            {
                currList.Add(currValue);
                currSum += currValue;

                Gen_CombinationTask216(currList, resultCombination, currValue + 1, length, currSum, sum);

                currSum -= currValue;
                currList.RemoveAt(currList.Count - 1);
                Gen_CombinationTask216(currList, resultCombination, currValue + 1, length, currSum, sum);
            }
            else
            {
                Gen_CombinationTask216(currList, resultCombination, currValue + 1, length, currSum, sum);
            }
        }
    }
}

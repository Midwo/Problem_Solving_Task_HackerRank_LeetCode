using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_77
    {
        ////77. Combinations(MEDIUM)        
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> result = new List<IList<int>>();

            Gen_Combinations(result, 1, n, k, new List<int>());   

            return result;
        }

        private void Gen_Combinations(List<IList<int>> resultLists, int currvValue, int maxValue, int maxLenght, IList<int> currList) 
        { 
            if (currList.Count == maxLenght)
            {
                resultLists.Add(new List<int>(currList));
                return;
            }

            if(currvValue > maxValue)
            {
                return;
            }

            for (int i = currvValue; i <= maxValue; i++)
            {
                currList.Add(i);
                Gen_Combinations(resultLists, i+1, maxValue, maxLenght, currList);
                currList.RemoveAt(currList.Count - 1);
            }
        }
    }
}

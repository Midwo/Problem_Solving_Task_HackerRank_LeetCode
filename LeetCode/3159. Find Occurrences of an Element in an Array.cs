using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3159
    {
        ////(3159.) Find Occurrences of an Element in an Array (MEDIUM)
        public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
        {
            List<int> indexCountXNums = new List<int>();
            int countXinNums = 0;
            List<int> outputList = new List<int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == x)
                {
                    countXinNums++;
                    indexCountXNums.Add(i);
                }
            }

            int howManySearch = 0;
            for (int i = 0; i < queries.Length; i++) 
            {
                howManySearch = queries[i];
                if(countXinNums >= howManySearch)
                {
                    outputList.Add(indexCountXNums[howManySearch-1]);
                }
                else
                {
                    outputList.Add(-1);
                }
            }

            return outputList.ToArray();
        }
    }
}

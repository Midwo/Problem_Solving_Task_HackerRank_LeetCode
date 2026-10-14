using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2900
    {
        ////(2900.) Longest Unequal Adjacent Groups Subsequence I (EASY)
        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            IList<string> startWithZeroList = new List<string>();
            IList<string> startWithOneList = new List<string>();
            int startWithZeroWhatNeedNow = 0;
            int startWithOneWhatNeedNow = 1;

            for (int index = 0; index < groups.Length; index++) 
            { 
                int group = groups[index];
                
                if(group == startWithOneWhatNeedNow)
                {
                    startWithOneList.Add(words[index]);
                    startWithOneWhatNeedNow = group == 1 ? 0 : 1;
                }
                if(group == startWithZeroWhatNeedNow)
                {
                    startWithZeroList.Add(words[index]);
                    startWithZeroWhatNeedNow = group == 1 ? 0 : 1;
                }
            }
            
            return startWithZeroList.Count > startWithOneList.Count ? startWithZeroList : startWithOneList; 
        }
    }
}

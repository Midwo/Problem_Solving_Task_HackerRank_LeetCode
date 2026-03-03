using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2085
    {
        ////(2085.) Count Common Words With One Occurrence (EASY)
        public int CountWords(string[] words1, string[] words2)
        {
            HashSet<string> words1Count1 = new HashSet<string>();
            HashSet<string> words1Count2OrMore = new HashSet<string>();

            foreach(string currWord in words1)
            {
                if (!words1Count1.Add(currWord)) 
                {
                    words1Count2OrMore.Add(currWord);
                }                
            }

            foreach (string currWord in words1Count2OrMore)
            {
                words1Count1.Remove(currWord);
            }

            HashSet<string> words2Count1 = new HashSet<string>();
            HashSet<string> words2Count2OrMore = new HashSet<string>();

            foreach (string currWord in words2)
            {
                if (!words2Count1.Add(currWord))
                {
                    words2Count2OrMore.Add(currWord);
                }
            }

            foreach (string currWord in words2Count2OrMore)
            {
                words2Count1.Remove(currWord);
            }

            int countCommon = 0;

            foreach (string currWord in words2Count1)
            {
                if (words1Count1.Contains(currWord))
                {
                    countCommon++;
                }
            }


            return countCommon;
        }
    }
}

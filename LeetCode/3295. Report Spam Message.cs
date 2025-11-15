using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3295
    {
        ////(3295.) Report Spam Message (MEDIUM)
        public bool ReportSpam(string[] message, string[] bannedWords)
        {
            int count = 0;
            HashSet<string> bannedWordsHashSet = new HashSet<string>();

            foreach (string word in bannedWords) 
            { 
                bannedWordsHashSet.Add(word);
            }

            foreach (string item in message) 
            { 
                if (bannedWordsHashSet.Contains(item))
                {
                    count++;
                    if (count > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

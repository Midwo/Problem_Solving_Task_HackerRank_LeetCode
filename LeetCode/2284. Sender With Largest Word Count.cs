using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2284
    {
        ////(2284.) Sender With Largest Word Count (MEDIUM)
        public string LargestWordCount(string[] messages, string[] senders)
        {
            int maxWords = -1;
            string nameMaxWords = string.Empty;
            Dictionary<string, int> dictionarySendersCountWords = new Dictionary<string, int>();

            for (int index = 0; index < messages.Length; index++)
            {
                int countWord = messages[index].Split(' ').Length;
                string sender = senders[index];
                if (dictionarySendersCountWords.ContainsKey(sender))
                {
                    int currCountWord = dictionarySendersCountWords[sender] + countWord;
                    dictionarySendersCountWords[sender] = currCountWord;
                    
                    if(maxWords < currCountWord || maxWords == currCountWord && string.Compare(sender, nameMaxWords, StringComparison.Ordinal) > 0)
                    {
                        maxWords = currCountWord;
                        nameMaxWords = sender;
                    }
                }
                else
                {
                    if(maxWords < countWord || maxWords == countWord && string.Compare(sender, nameMaxWords, StringComparison.Ordinal) > 0)
                    {
                        maxWords = countWord;
                        nameMaxWords = sender;
                    }
                    dictionarySendersCountWords.Add(sender, countWord);
                }
            }

            return nameMaxWords;
        }
    }
}

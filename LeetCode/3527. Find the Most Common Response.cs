using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3527
    {
        ////(3527.) Find the Most Common Response (MEDIUM)
        public string FindCommonResponse(IList<IList<string>> responses)
        {
            Dictionary<string, int> dictWordCount = new Dictionary<string, int>();
            int maxCount = 1;
            for (int i = 0; i < responses.Count; i++)
            {
                HashSet<string> distinctWords = new HashSet<string>();
                for (int j = 0; j < responses[i].Count; j++)
                {
                    string currWord = responses[i][j];
                    if (distinctWords.Add(currWord))
                    {
                        if (dictWordCount.ContainsKey(currWord))
                        {
                            dictWordCount[currWord]++;
                            if(dictWordCount[currWord] > maxCount)
                            {
                                maxCount = dictWordCount[currWord];
                            }
                        }
                        else
                        {
                            dictWordCount.Add(currWord, 1);
                        }
                    }
                }
            }

            List<string> maxCountWord = new List<string>();

            foreach (var item in dictWordCount) 
            { 
                if (item.Value == maxCount)
                {
                    maxCountWord.Add(item.Key);
                }
            }

            maxCountWord.Sort();

            return maxCountWord[0];
        }
    }
}

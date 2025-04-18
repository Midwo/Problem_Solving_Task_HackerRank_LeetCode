using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_884
    {
        ////(884.) Uncommon Words from Two Sentences (EASY)
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> dictionaryS1 = new Dictionary<string, int>();
            Dictionary<string, int> dictionaryS2 = new Dictionary<string, int>();
            List<string> resultList = new List<string>(); 
            
            string tempString = string.Empty;
            for (int i = 0; i < s1.Length; i++)
            {
                char currChar = s1[i];
                if (currChar != ' ')
                {
                    tempString += currChar;
                }
                else
                {
                    if (dictionaryS1.ContainsKey(tempString))
                    {
                        dictionaryS1[tempString]++;
                    }
                    else
                    {
                        dictionaryS1.Add(tempString, 1);
                    }
                    tempString = string.Empty;
                }
            }
            if(tempString != string.Empty)
            {
                if (dictionaryS1.ContainsKey(tempString))
                {
                    dictionaryS1[tempString]++;
                }
                else
                {
                    dictionaryS1.Add(tempString, 1);
                }
                tempString = string.Empty;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                char currChar = s2[i];
                if (currChar != ' ')
                {
                    tempString += currChar;
                }
                else
                {
                    if (dictionaryS2.ContainsKey(tempString))
                    {
                        dictionaryS2[tempString]++;
                    }
                    else
                    {
                        dictionaryS2.Add(tempString, 1);
                    }
                    tempString = string.Empty;
                }
            }
            if (tempString != string.Empty)
            {
                if (dictionaryS2.ContainsKey(tempString))
                {
                    dictionaryS2[tempString]++;
                }
                else
                {
                    dictionaryS2.Add(tempString, 1);
                }
                tempString = string.Empty;
            }
            foreach (var item in dictionaryS1)
            {
                if (item.Value == 1)
                {
                    if (!dictionaryS2.ContainsKey(item.Key))
                    {
                        resultList.Add(item.Key);
                        dictionaryS1.Remove(item.Key);
                    }
                    else
                    {
                        dictionaryS2.Remove(item.Key);
                        dictionaryS1.Remove(item.Key);
                    }
                }
            }

            foreach (var item in dictionaryS2)
            {
                if (item.Value == 1)
                {
                    if (!dictionaryS1.ContainsKey(item.Key))
                    {
                        resultList.Add(item.Key);
                    }
                    else
                    {
                        dictionaryS1.Remove(item.Key);
                    }
                }
            }
            return resultList.ToArray();
        }
    }
}

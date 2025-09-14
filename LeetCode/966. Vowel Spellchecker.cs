using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_966
    {
        ////(966.) Vowel Spellchecker (MEDIUM)
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            Dictionary<string, string> distinctWordList = new Dictionary<string, string>();
            Dictionary<string, string> distinctToLowerWordList = new Dictionary<string, string>();
            Dictionary<string, string> changeCharsDistinctToLowerWordList = new Dictionary<string, string>();

            foreach (string word in wordlist) 
            {
                distinctWordList.TryAdd(word, word);
                distinctToLowerWordList.TryAdd(word.ToLower(), word);
                char[] tempWord = word.ToLower().ToCharArray();
               
                for (int x = 0; x < tempWord.Length; x++)
                {
                    if (tempWord[x] == 'e' || tempWord[x] == 'i' || tempWord[x] == 'o' || tempWord[x] == 'u')
                    {
                        tempWord[x] = 'a';
                    }
                }
                changeCharsDistinctToLowerWordList.TryAdd(new string(tempWord), word);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                if (distinctWordList.ContainsKey(queries[i]))
                {
                    queries[i] = distinctWordList[queries[i]];
                }
                else if (distinctToLowerWordList.ContainsKey(queries[i].ToLower()))
                {
                    queries[i] = distinctToLowerWordList[(queries[i].ToLower())];
                }
                else
                {
                    char[] tempWord = queries[i].ToLower().ToCharArray();

                    for (int x = 0; x < tempWord.Length; x++)
                    {
                        if (tempWord[x] == 'e' || tempWord[x] == 'i' || tempWord[x] == 'o' || tempWord[x] == 'u')
                        {
                            tempWord[x] = 'a';
                        }
                    }

                    if (changeCharsDistinctToLowerWordList.ContainsKey(new string(tempWord)))
                    {
                        queries[i] = changeCharsDistinctToLowerWordList[(new string(tempWord))];
                    }
                    else
                    {
                        queries[i] = string.Empty;
                    }
                }
            }

            return queries;



            //// LTE - Time Limit Exceeded
            
            //int lengthQueries = queries.Length;
            //int lengthWordList = wordlist.Length;
            //string[] smallWordList = new string[lengthWordList];
            //string[] replaceCharsWordList = new string[lengthWordList];
            //bool replaceCharsWordListGenerate = false;
            //bool generateSmall = false;
            //string last = string.Empty;



            //for (int i = 0; i < lengthQueries; i++) 
            //{
            //    string currString = queries[i];
            //    if (last == currString)
            //    {
            //        queries[i] = queries[i - 1];
            //        continue;
            //    }
            //    bool breakLoop = false;
            //    int findIndex = int.MaxValue;
            //    for (int j = 0; j < lengthWordList; j++)
            //    {
            //        if(currString == wordlist[j])
            //        {
            //            queries[i] = currString;
            //            last = currString;
            //            breakLoop = true;
            //            break;
            //        }
            //    }
            //    if (breakLoop)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        if (!generateSmall)
            //        {
            //            for (int k = 0; k < lengthWordList; k++)
            //            {
            //                smallWordList[k] = wordlist[k].ToLower();
            //            }
            //            generateSmall = true;
            //        }
            //        string currStringLower = currString.ToLower();
            //        for (int j = 0; j < lengthWordList; j++)
            //        {
            //            if (currStringLower == smallWordList[j])
            //            {
            //                findIndex = Math.Min(findIndex, j);
            //                break;
            //            }
            //        }
            //    }
            //    if (findIndex < int.MaxValue)
            //    {
            //        last = wordlist[findIndex];
            //        queries[i] = wordlist[findIndex];
            //        continue;
            //    }
            //    else
            //    {
            //        string currStringLower = currString.ToLower();
            //        for (int j = 0; j < lengthWordList; j++)
            //        {
            //            char[] tempWord = new char[currStringLower.Length];
            //            for (int x = 0; x < currStringLower.Length; x++)
            //            {
            //                if (currStringLower[x] == 'e' || currStringLower[x] == 'i' || currStringLower[x] == 'o' || currStringLower[x] == 'u')
            //                {
            //                    tempWord[x] = 'a';
            //                }
            //                else
            //                {
            //                    tempWord[x] = currStringLower[x];
            //                }
            //            }
            //            currString = new string(tempWord);
            //        }

            //        findIndex = int.MaxValue;
            //        if (!replaceCharsWordListGenerate)
            //        {
            //            for (int h = 0; h < lengthWordList; h++)
            //            {
            //                char[] tempWord = new char[smallWordList[h].Length];
            //                for (int j = 0; j < smallWordList[h].Length; j++)
            //                {
            //                    if (smallWordList[h][j] == 'e' || smallWordList[h][j] == 'i' || smallWordList[h][j] == 'o' || smallWordList[h][j] == 'u')
            //                    {
            //                        tempWord[j] = 'a';
            //                    }
            //                    else
            //                    {
            //                        tempWord[j] = smallWordList[h][j];
            //                    }
            //                }
            //                replaceCharsWordList[h] = new string(tempWord);
            //            }
            //            replaceCharsWordListGenerate = true;
            //        }

            //        for (int x = 0; x < lengthWordList; x++)
            //        {
            //            if (currString == replaceCharsWordList[x])
            //            {
            //                findIndex = x;
            //                last = wordlist[x];
            //                queries[i] = wordlist[x];
            //                break;
            //            }
            //        }
            //        if (findIndex == int.MaxValue)
            //        {
            //            last = queries[i];
            //            queries[i] = String.Empty;
            //        }
            //    }
            //}
            //return queries;
        }
    }
}

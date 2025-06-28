using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_49
    {
        ////(49.) Group Anagrams (MEDIUM)
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            // Runtime: 17 ms.

            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> dictionaryString = new Dictionary<string, List<string>>();

            foreach (string str in strs) 
            {
                int[] charsCount = new int[26];

                foreach (char charStr in str) 
                {
                    charsCount[charStr - 'a']++;    
                }

                string keyForDictionaryString = string.Join(',', charsCount);

                if (!dictionaryString.ContainsKey(keyForDictionaryString))
                {
                    dictionaryString.Add(keyForDictionaryString, new List<string>());
                    dictionaryString[keyForDictionaryString].Add(str);
                }
                else
                {
                    dictionaryString[keyForDictionaryString].Add(str);
                }

            }

            return dictionaryString.Values.ToList<IList<string>>();


            //// Runtime: 226 ms.

            //IList<IList<string>> result = new List<IList<string>>();

            //List<string> sortCharsList = new List<string>();
            //int index;

            //foreach (string str in strs) 
            //{
            //    char[] currChars = str.ToCharArray();
            //    Array.Sort(currChars);
            //    string temp = new string (currChars);
            //    if (sortCharsList.Contains(temp))
            //    {
            //        index = sortCharsList.IndexOf(new string (temp));
            //        result[index].Add(str);
            //    }
            //    else
            //    {
            //        sortCharsList.Add(temp);
            //        result.Add(new List<string> { str });
            //    }
            //}
            //return result;
        }
    }
}

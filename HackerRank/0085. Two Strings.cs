using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0085
    {
        ////85. Two Strings (EASY)
        public string twoStrings(string s1, string s2)
        {
            ////Solution 1 (New)

            var statusChar = new bool[26];

            foreach (var currChar in s1)
            {
                statusChar[currChar-'a'] = true;
            }

            foreach (var currChar in s2)
            {
                if (statusChar[currChar - 'a'])
                    return "YES";
            }

            return "NO";

            ////Solution 2 (Old)

            //bool yesOrNot = false;

            //Dictionary<char, int> dictionaryKeyString = new Dictionary<char, int>();

            //foreach (char item in s1)
            //{
            //    if (!dictionaryKeyString.ContainsKey(item))
            //    {
            //        dictionaryKeyString.Add(item, 1);
            //    }
            //}
            //foreach (char item in s2)
            //{
            //    if (dictionaryKeyString.ContainsKey(item))
            //    {
            //        dictionaryKeyString[item]++;
            //        break;
            //    }
            //}
            //foreach (int item in dictionaryKeyString.Values)
            //{
            //    if (item > 1)
            //    {
            //        yesOrNot = true;
            //        break;
            //    }
            //}

            //if (yesOrNot)
            //{
            //    return "YES";
            //}
            //else
            //{
            //    return "NO";

            //}
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0087
    {
        ////87. Making Anagrams (EASY)
        public int makingAnagrams(string s1, string s2)
        {
            //Solution 1 (New)

            var diffCharsTable = new int[26];

            foreach (var currChar in s1)
            {
                diffCharsTable[currChar -'a']++;
            }

            foreach (var currChar in s2)
            {
                diffCharsTable[currChar - 'a']--;
            }

            var countOperationsDelete = 0;

            foreach (var diff in diffCharsTable)
            {
                countOperationsDelete += diff > 0 ? diff : -diff;
            }

            return countOperationsDelete;

            //Solution 2 (Old)
            //Dictionary<char, int> dictionarys1 = new Dictionary<char, int>();
            //Dictionary<char, int> dictionarys2 = new Dictionary<char, int>();
            //int howLongS1 = s1.Length;
            //int howLongS2 = s2.Length;
            //int howManyTooSame = 0;

            //foreach (char i in s1)
            //{
            //    if (!dictionarys1.ContainsKey(i))
            //    {
            //        dictionarys1.Add(i, 1);
            //    }
            //    else
            //    {
            //        int x = dictionarys1[i] + 1;
            //        dictionarys1[i] = x;
            //    }
            //}

            //foreach (char i in s2)
            //{
            //    if (!dictionarys2.ContainsKey(i))
            //    {
            //        dictionarys2.Add(i, 1);
            //    }
            //    else
            //    {
            //        int x = dictionarys2[i] + 1;
            //        dictionarys2[i] = x;
            //    }
            //}

            //foreach (var i in dictionarys1)
            //{
            //    foreach (var x in dictionarys2)
            //    {
            //        if (i.Key == x.Key)
            //        {
            //            if (i.Value < x.Value)
            //            {
            //                howManyTooSame += i.Value;
            //            }
            //            else
            //            {
            //                howManyTooSame += x.Value;
            //            }
            //        }
            //    }
            //}
            //return howLongS1 + howLongS2 - howManyTooSame * 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0095
    {
        ////95. Gemstones (EASY)
        public int gemstones(List<string> arr)
        {
            ////Solution 1 (New)
            var countFreq = new int[26];

            foreach (var item in arr) 
            {
                var itExists = new bool[26];
                foreach (var currChar in item) 
                { 
                    itExists[currChar - 'a'] = true;
                }
                for (int i = 0; i < 26; i++) 
                {
                    if (itExists[i])
                        countFreq[i]++;
                }
            }

            var countCharsInAll = 0;

            foreach (var item in countFreq)
            {
                if (item == arr.Count)
                    countCharsInAll++;
            }


            return countCharsInAll;

            ////Solution 2 (Old)
            //int sizeArr = arr.Count;
            //Dictionary<char, int> dictionaryForArr = new Dictionary<char, int>();
            //Dictionary<char, int> sumDictionaryForArr = new Dictionary<char, int>();
            //int totalTooSameCollection = 0;

            //foreach (string str in arr)
            //{
            //    foreach (char x in str)
            //    {
            //        if (!dictionaryForArr.ContainsKey(x))
            //        {
            //            dictionaryForArr.Add(x, 1);
            //        }
            //    }
            //    foreach (var y in dictionaryForArr)
            //    {
            //        if (sumDictionaryForArr.ContainsKey(y.Key))
            //        {
            //            sumDictionaryForArr[y.Key]++;
            //        }
            //        else
            //        {
            //            sumDictionaryForArr.Add((char)y.Key, 1);
            //        }
            //    }
            //    dictionaryForArr.Clear();
            //}
            //foreach (var y in sumDictionaryForArr)
            //{
            //    if (sizeArr == y.Value)
            //    {
            //        totalTooSameCollection++;
            //    }
            //}
            //return totalTooSameCollection;
        }

    }
}

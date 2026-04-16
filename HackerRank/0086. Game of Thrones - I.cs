using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0086
    {
        ////86. Game of Thrones - I (EASY)
        public string gameOfThrones(string s)
        {
            ////Solution 1 (New)
            var countOdd = 0;
            var countChars = new int[26];

            foreach (var currChar in s) 
            {
                countChars[currChar - 'a']++;
            }

            foreach (var currChar in countChars)
            {
                // if((currChar % 2) == 1)
                if ((currChar & 1) == 1)
                {
                    countOdd++;
                }
            }

            return countOdd > 1 ? "NO" : "YES";

            ////Solution 2 (Old)
            //Dictionary<char, int> dictionaryString = new Dictionary<char, int>();
            //int howManyOdd = 0;
            //foreach (char item in s)
            //{
            //    if (dictionaryString.ContainsKey(item))
            //    {
            //        dictionaryString[item]++;
            //    }
            //    else
            //    {
            //        dictionaryString.Add(item, 1);
            //    }
            //}
            //foreach (var item in dictionaryString)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        howManyOdd++;
            //    }
            //}
            //return howManyOdd <= 1 ? "YES" : "NO";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0084
    {
        ////84. String Construction (EASY)
        public int stringConstruction(string s)
        {
            ////Solution 1 (New)
            var hashSetChars = new HashSet<char>();

            foreach (char c in s) 
            { 
                hashSetChars.Add(c);
            }

            return hashSetChars.Count;


            ////Solution 2 (Old)

            //Dictionary<int, int> dictionary = new Dictionary<int, int>();

            //foreach (char i in s)
            //{
            //    if (!dictionary.ContainsKey(i))
            //    {
            //        dictionary.Add(i, 1);
            //    }
            //    else
            //    {
            //        int x = dictionary[i] + 1;
            //        dictionary[i] = x;
            //    }
            //}
            //int howmany = 0;
            //foreach (var item in dictionary)
            //{
            //    howmany++;
            //}
            //return howmany;
        }
    }
}

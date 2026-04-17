using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0094
    {
        ////94. Alternating Characters (EASY)
        public int alternatingCharacters(string s)
        {
            ////Solution 1 (New)
            var removeCount = 0;
            var lastChar = s[0];

            for (var index = 1; index < s.Length; index++) 
            {
                var currChar = s[index];
                if (lastChar == currChar)
                    removeCount++;
                else
                    lastChar = s[index];
            }

            return removeCount;


            ////Solution 2 (Old)

            //int howManydelete = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (i < s.Length - 1)
            //    {
            //        if ((int)s[i] == (int)s[i + 1])
            //        {
            //            howManydelete++;
            //        }
            //    }
            //    //Console.WriteLine(s[i].ToString());

            //}
            //return howManydelete;
        }

    }
}

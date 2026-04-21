using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0111
    {
        ////111. CamelCase (EASY)
        public int camelcase(string s)
        {
            ////Solution 1 (New - Better)

            var countUpperChar = 1;

            foreach (var currchar in s)
            {
                if(char.IsUpper(currchar))
                    countUpperChar++;
            }

            return countUpperChar;

            ////Solution 2 (Old - Poor)
            //int howManyUpper = 0;
            //bool firstNoUpperWord = true;
            //foreach (char i in s)
            //{
            //    howManyUpper = !char.IsUpper(i) && firstNoUpperWord ? ++howManyUpper : howManyUpper;
            //    firstNoUpperWord = false;
            //    howManyUpper = char.IsUpper(i) ? ++howManyUpper : howManyUpper;

            //}
            //return howManyUpper;
        }
    }
}

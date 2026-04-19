using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0104
    {
        ////104. Mars Exploration (EASY)
        public int marsExploration(string s)
        {
            ////Solution 1 (New - Better)
            var countChangedChars = 0;

            for (int i = 0; i < s.Length-2; i +=3)
            {
                if (s[i] != 'S')
                    countChangedChars++;
                if (s[i+1] != 'O')
                    countChangedChars++;
                if (s[i + 2] != 'S')
                    countChangedChars++;
            }

            return countChangedChars;

            ////Solution 2 (Old - Poor)
            //string firstAndLastCharCeq = "S";
            //string middleCharCeq = "O";
            //string firstChar = string.Empty;
            //string middleChar = string.Empty;
            //string lastChar = string.Empty;
            //int howMany = 0;

            //for (int i = 0; i < s.Length - 2; i++)
            //{
            //    firstChar = s[i].ToString();
            //    middleChar = s[i + 1].ToString();
            //    lastChar = s[i + 2].ToString();
            //    if (firstChar == firstAndLastCharCeq && lastChar == firstAndLastCharCeq && middleChar == middleCharCeq)
            //    {
            //        i += 2;
            //    }
            //    else if (firstChar == firstAndLastCharCeq && lastChar == firstAndLastCharCeq && middleChar != middleCharCeq ||
            //             firstChar == firstAndLastCharCeq && lastChar != firstAndLastCharCeq && middleChar == middleCharCeq ||
            //             firstChar != firstAndLastCharCeq && lastChar == firstAndLastCharCeq && middleChar == middleCharCeq)
            //    {
            //        howMany++;
            //        i += 2;
            //    }
            //    else if (firstChar == firstAndLastCharCeq && lastChar != firstAndLastCharCeq && middleChar != middleCharCeq ||
            //         firstChar != firstAndLastCharCeq && lastChar == firstAndLastCharCeq && middleChar != middleCharCeq ||
            //         firstChar != firstAndLastCharCeq && lastChar != firstAndLastCharCeq && middleChar == middleCharCeq)
            //    {
            //        howMany += 2;
            //        i += 2;
            //    }
            //    else
            //    {
            //        howMany += 3;
            //        i += 2;
            //    }
            //}
            //return howMany;
        }
    }
}

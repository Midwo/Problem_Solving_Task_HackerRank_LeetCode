using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0093
    {
        ////93. Beautiful Binary String (EASY)
        public int beautifulBinaryString(string b)
        {
            ////Solution 1 (New)
            var changeCount = 0;
            for (int i = 0; i < b.Length-2; i++)
            {
                if (b[i] == '0' && b[i + 1] == '1' && b[i + 2] == '0')
                {
                    i += 2;
                    changeCount++;
                }
            }

            return changeCount;

            ////Solution 2 (Old)
            //string firstAndLastChar = "0";
            //string MiddleChar = "1";
            //int howMany = 0;

            //for (int i = 0; i < b.Length - 2; i++)
            //{
            //    if (b[i].ToString() == firstAndLastChar && b[i + 2].ToString() == firstAndLastChar && b[i + 1].ToString() == MiddleChar)
            //    {
            //        howMany++;
            //        i += 2;
            //    }
            //}
            //return howMany;
        }

    }
}

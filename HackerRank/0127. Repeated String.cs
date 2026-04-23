using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0127
    {
        ////127. Repeated String (EASY)
        public long repeatedString(string s, long n)
        {
            ////Solution 1 (New)
            long sumA = 0;
            int lengthS = s.Length;
            int totalAInS = 0;

            long multiplier = n / lengthS;
            long indexStopSum = n % lengthS;

            for (int i = 0; i < lengthS; i++)
            {
                if (s[i] == 'a')
                    totalAInS++;
                if (i == indexStopSum-1)
                    sumA = totalAInS;
            }

            return sumA + totalAInS * multiplier;


            ////Solution 2 (Old)
            //double howManyDivideDouble = n / s.Length;
            //long howManyDivideLong = (long)howManyDivideDouble;


            //long restFromDivideLong = n - howManyDivideLong * s.Length;


            //int howManyAInString = 0;

            //foreach (char i in s)
            //{
            //    howManyAInString = i.ToString() == "a" ? ++howManyAInString : howManyAInString;
            //}


            //int howManyAInStringInRest = 0;

            //for (int i = 0; i < restFromDivideLong; i++)
            //{
            //    howManyAInStringInRest = s[i].ToString() == "a" ? ++howManyAInStringInRest : howManyAInStringInRest;
            //}

            //return howManyAInStringInRest + howManyAInString * howManyDivideLong;
        }
    }
}

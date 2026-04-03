using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0021
    {
        public string timeInWords(int h, int m)
        {
            string outputPrint = string.Empty;
            Dictionary<int, string> numbersTime = new Dictionary<int, string>
        {
            { 0, "o' clock" }, { 1, "one" }, { 2, "two" }, { 3, "three"}, { 4, "four"},
            { 5, "five"}, { 6, "six"}, { 7, "seven"}, { 8, "eight"}, { 9, "nine"},
            {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"},
            {15, "quarter"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"},
            {19, "nineteen"}, {20, "twenty"}, {21, "twenty one"}, {22, "twenty two"},
            {23, "twenty three"}, {24, "twenty four"}, {25, "twenty five"}, {26, "twenty six"},
            {27, "twenty seven"}, {28, "twenty eight"}, {29, "twenty nine"}, {30, "half"}
        };
            switch (m)
            {
                case 0:
                    outputPrint = numbersTime[h] + " " + numbersTime[0];
                    break;
                case 15:
                    outputPrint = numbersTime[m] + " past " + numbersTime[h];
                    break;
                case 30:
                    outputPrint = numbersTime[m] + " past " + numbersTime[h];
                    break;
                case 45:
                    outputPrint = numbersTime[60 - m] + " to " + numbersTime[h + 1];
                    break;
                case <= 10:
                    outputPrint = numbersTime[m] + " minute past " + numbersTime[h];
                    break;
                case <= 30:
                    outputPrint = numbersTime[m] + " minutes past " + numbersTime[h];
                    break;
                case > 30:
                    outputPrint = numbersTime[60 - m] + " minutes to " + numbersTime[h + 1];
                    break;
            }
            return outputPrint;
        }

    }
}

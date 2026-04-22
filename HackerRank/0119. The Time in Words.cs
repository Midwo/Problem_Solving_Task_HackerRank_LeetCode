using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0119
    {
        ////119. The Time in Words (MEDIUM)
        public string timeInWords(int h, int m)
        {
            var words = new Dictionary<int, string>
            {
                {0, "o' clock"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
                {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"},
                {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"},
                {14, "fourteen"}, {15, "quarter"}, {16, "sixteen"}, {17, "seventeen"},
                {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"}, {21, "twenty one"},
                {22, "twenty two"}, {23, "twenty three"}, {24, "twenty four"},
                {25, "twenty five"}, {26, "twenty six"}, {27, "twenty seven"},
                {28, "twenty eight"}, {29, "twenty nine"}, {30, "half"}
            };

            if (m == 0)
                return $"{words[h]} {words[0]}";

            if (m == 15)
                return $"{words[15]} past {words[h]}";

            if (m == 30)
                return $"{words[30]} past {words[h]}";

            if (m == 45)
                return $"{words[15]} to {words[h + 1]}";

            if (m < 30)
                return $"{words[m]} {(m == 1 ? "minute" : "minutes")} past {words[h]}";

            int to = 60 - m;
            return $"{words[to]} {(to == 1 ? "minute" : "minutes")} to {words[h + 1]}";
        }
    }
}

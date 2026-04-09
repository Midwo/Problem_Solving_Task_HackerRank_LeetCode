using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0041
    {
        ////41. Day of the Programmer (EASY)
        public string dayOfProgrammer(int year)
        {
            string whenDate = string.Empty;

            if (year < 1918)
            {
                if (year % 4 == 0)
                {
                    whenDate = "12";
                }
                else
                {
                    whenDate = "13";

                }
            }
            else if (year > 1918)
            {
                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    whenDate = "12";
                }
                else
                {
                    whenDate = "13";
                }
            }
            else
            {
                whenDate = "26";
            }
            return whenDate + ".09." + year;
        }
    }
}

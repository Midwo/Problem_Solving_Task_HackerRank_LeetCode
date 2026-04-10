using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0060
    {
        ////60. Library Fine (EASY)
        public int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            DateTime date1 = new DateTime(y1, m1, d1);
            DateTime date2 = new DateTime(y2, m2, d2);

            if (date1 <= date2)
            {
                return 0;
            }
            else if (date1.Year > date2.Year)
            {
                return 10000;
            }
            else if (date1.Month > date2.Month)
            {
                return (500 * (date1.Month - date2.Month));
            }
            else
            {
                return 15 * (int)(date1 - date2).Days;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0044
    {
        ////44. Counting Valleys (EASY)
        public int countingValleys(int steps, string path)
        {
            int countValley = 0;
            int height = 0;
            bool activeValley = false;
            foreach (char item in path)
            {
                if (item == (char)68)
                {
                    height--;
                }
                else if (item == (char)85)
                {
                    height++;
                }
                if (height < 0 && activeValley == false)
                {
                    activeValley = true;
                    countValley++;
                }
                else if (height >= 0)
                {
                    activeValley = false;
                }
            }

            return countValley;
        }
    }
}

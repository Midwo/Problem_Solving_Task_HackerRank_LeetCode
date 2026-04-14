using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0077
    {
        ////77. Maximum Perimeter Triangle (EASY)
        public List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            int length = sticks.Count;
            sticks.Sort();
            int longLengthStick = sticks[length - 1];
            int medLengthStick = sticks[length - 2];
            int shortLengthStick = sticks[length - 3];

            if(longLengthStick < medLengthStick + shortLengthStick)
            {
                return [shortLengthStick, medLengthStick, longLengthStick];
            }

            for (int index = length - 4; index >=0; index--)
            {
                longLengthStick = medLengthStick;
                medLengthStick = shortLengthStick;
                shortLengthStick = sticks[index];

                if (longLengthStick < medLengthStick + shortLengthStick)
                {
                    return [shortLengthStick, medLengthStick, longLengthStick];
                }
            }

            return [-1];
        }
    }
}

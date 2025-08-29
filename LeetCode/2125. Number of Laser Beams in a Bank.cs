using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2125
    {
        ////(2125.) Number of Laser Beams in a Bank (MEDIUM)
        public int NumberOfBeams(string[] bank)
        {
            int result = 0;
            int howManyLastLaser = 0;
           
            for (int i = 0; i < bank.Length; i++)
            {
                int currHowManyLaser = 0;
                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] == '1')
                    {
                        currHowManyLaser++;
                    }
                }
                if(currHowManyLaser > 0)
                {
                    result += howManyLastLaser * currHowManyLaser;

                    howManyLastLaser = currHowManyLaser;
                }
            }
           
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0047
    {
        ////47. The Hurdle Race (EASY)
        public int hurdleRace(int k, List<int> height)
        {
            int howManyPotions = 0;
            int heightWithPotion = k;
            for (int i = 0; i < height.Count; i++)
            {
                if (heightWithPotion < height[i])
                {
                    for (int x = heightWithPotion; x < height[i]; x++)
                    {
                        howManyPotions++;
                        heightWithPotion++;
                    }
                }

            }
            return howManyPotions;
        }
    }
}

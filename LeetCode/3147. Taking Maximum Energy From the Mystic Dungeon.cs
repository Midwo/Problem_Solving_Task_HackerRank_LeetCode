using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3147
    {
        ////(3147.) Taking Maximum Energy From the Mystic Dungeon (MEDIUM)
        public int MaximumEnergy(int[] energy, int k)
        {
            int maxEnergyEnd = int.MinValue;
            int lengthEnergy = energy.Length;

            for (int i = lengthEnergy-k; i < lengthEnergy; i++)
            {
                int currSumEnergy = 0;
                for (int j = i; j >= 0; j -= k)
                {
                    currSumEnergy += energy[j];
                    maxEnergyEnd = Math.Max(maxEnergyEnd, currSumEnergy);
                }
            }
            return maxEnergyEnd;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2300
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            Array.Sort(potions);
            int length = potions.Length;
            for (int i = 0; i < spells.Length; i++)
            {
                long tempValueSpell = spells[i];
                long minValue = success / tempValueSpell;
                if ((long)minValue * tempValueSpell < success)
                {
                    minValue++;
                }
                minValue--;
                int lIndex = 0;
                int rIndex = length;

                while (lIndex < rIndex)
                {         
                    int mid = (lIndex + rIndex) /2;

                    if (potions[mid] > minValue)
                    {
                        rIndex = mid;

                    }
                    else
                    {
                        lIndex = mid + 1;
                    }

                }

                spells[i] = length - lIndex;
            }
            return spells;
        }
    }
}

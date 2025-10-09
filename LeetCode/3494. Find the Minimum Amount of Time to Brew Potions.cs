using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3494
    {
        ////(3494.) Find the Minimum Amount of Time to Brew Potions (MEDIUM)
        public long MinTime(int[] skill, int[] mana)
        {
            int skillsCount = skill.Length;
            long[] times = new long[skillsCount];
            int manaCount = mana.Length;

            for (int indexMana = 0; indexMana < manaCount; indexMana++)
            {
                long currTime = 0;

                for (int indexSkill = 0; indexSkill < skillsCount; indexSkill++)
                {
                    currTime = Math.Max(currTime, times[indexSkill]) + (long)mana[indexMana] * skill[indexSkill];
                }

                times[skillsCount - 1] = currTime;

                for (int indexSkill = skillsCount - 2; indexSkill >= 0; indexSkill--)
                {
                    times[indexSkill] = times[indexSkill + 1] - (long)mana[indexMana] * skill[indexSkill + 1];
                }
            }

            return times[skillsCount - 1];
        }
    }
}

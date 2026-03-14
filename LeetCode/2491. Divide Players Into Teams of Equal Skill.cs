using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2491
    {
        ////(2491.) Divide Players Into Teams of Equal Skill (MEDIUM)
        public long DividePlayers(int[] skill)
        {
            Array.Sort(skill);

            int right = skill.Length - 1;
            int left = 1;
            int sumTwoPlayers = skill[0] + skill[right];
            long result = skill[0] * skill[right];
            right--;


            while(left < right)
            {
                long currSum = skill[left] + skill[right];
                if (currSum != sumTwoPlayers) { return -1; }
                result += skill[left++] * skill[right--];
            }

            return result;
        }
    }
}

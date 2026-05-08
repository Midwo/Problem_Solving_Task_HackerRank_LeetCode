using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2554
    {
        ////(2554.) Maximum Number of Integers to Choose From a Range I (MEDIUM)
        public int MaxCount(int[] banned, int n, int maxSum)
        {
            var bannedList = new HashSet<int>();

            foreach (var number in banned)
            {
                bannedList.Add(number);
            }

            int countNumber = 0;
            int currSum = 0;
            int currNumber = 0;

            while (currNumber < n) 
            {
                currNumber++;
                if (bannedList.Contains(currNumber))
                    continue;
                currSum += currNumber;
                if (currSum <= maxSum)
                    countNumber++;
                else
                {
                    break;
                }
            }

            return countNumber;
        }
    }
}

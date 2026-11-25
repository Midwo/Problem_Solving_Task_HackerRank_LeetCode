using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2698
    {
        ////(2698.) Find the Punishment Number of an Integer (MEDIUM)
        public int PunishmentNumber(int n)
        {
            int sumPunishmentNumber = 1;
            bool isPossible = false;

            for (int currNumber = 2; currNumber <= n; currNumber++)
            {
                int valueToPartition = currNumber * currNumber;
                int length = valueToPartition.ToString().Length;
                isPossible = false;
                PartitionNumber(0, valueToPartition, currNumber, valueToPartition);
            }

            void PartitionNumber(int sum, int currValueToPartition, int currNumberLoop, int originalValue)
            {
                if (isPossible || sum > currNumberLoop)
                    return;

                if (currValueToPartition == 0 && sum == currNumberLoop)
                {
                    sumPunishmentNumber += originalValue;
                    isPossible = true;
                    return;
                }
                else if(currValueToPartition == 0)
                {
                    return;
                }

                int divisor = 10;
                
                while (divisor <= currValueToPartition  * 10)
                {
                    PartitionNumber(sum + (currValueToPartition % divisor), currValueToPartition / divisor, currNumberLoop, originalValue);

                    divisor *= 10;
                }
            }

            return sumPunishmentNumber;
        }
    }
}

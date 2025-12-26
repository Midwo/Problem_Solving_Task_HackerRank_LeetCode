using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2483
    {
        ////(2483.) Minimum Penalty for a Shop (MEDIUM)
        public int BestClosingTime(string customers)
        {
            int length = customers.Length;
            int sumPenalty = 0;

            for (int i = 0; i < length; i++)
            {
                if (customers[i] == 'Y')
                {
                    sumPenalty++;
                }
            }

            int minPenalty = sumPenalty;
            int minIndexPenalty = 0;

            for (int i = 0; i < length; i++)
            {
                if (customers[i] == 'Y')
                {
                    sumPenalty--;
                }
                else
                {
                    sumPenalty++;
                }
                if (minPenalty > sumPenalty)
                {
                    minPenalty = sumPenalty;
                    minIndexPenalty = i+1;     
                }
            }

            return minIndexPenalty;

            //int length = customers.Length;
            //int[] dpPenaltySum = new int[length+1];
            //int minPenalty = int.MaxValue;
            //int minPenaltyIndex = int.MaxValue;
            //int reverseIndex = length-1;
            //int forwardSum = 0;
            //int reverseSum = 0;
            //for (int i = 0; i < length; i++) 
            //{ 
            //    if (customers[i] == 'N')
            //    {
            //       forwardSum++;
            //    }
            //    if (customers[reverseIndex] == 'Y')
            //    {
            //        reverseSum++;
            //    }
            //    dpPenaltySum[reverseIndex] += reverseSum;
            //    dpPenaltySum[i+1] += forwardSum;

            //    if (reverseIndex <= i + 1)
            //    {
            //        if (minPenalty >= dpPenaltySum[reverseIndex])
            //        {
            //            if (minPenalty > dpPenaltySum[reverseIndex])
            //            {
            //                minPenalty = dpPenaltySum[reverseIndex];
            //                minPenaltyIndex = reverseIndex;
            //            }
            //            else if (minPenaltyIndex > reverseIndex)
            //            {
            //                minPenaltyIndex = reverseIndex;
            //            }
            //        }
            //        if (minPenalty >= dpPenaltySum[i + 1])
            //        {
            //            if (minPenalty > dpPenaltySum[i + 1])
            //            {
            //                minPenalty = dpPenaltySum[i + 1];
            //                minPenaltyIndex = i + 1;
            //            }
            //            else if (minPenaltyIndex > i + 1)
            //            {
            //                minPenaltyIndex = i + 1;
            //            }
            //        }
            //    }

            //    reverseIndex--;
            //}

            //return minPenaltyIndex;
        }
    }
}

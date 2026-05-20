using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2073
    {
        ////(2073.) Time Needed to Buy Tickets (EASY)
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int sumTime = 0;
            int targetTickets = tickets[k];

            for (int i = 0; i < tickets.Length; i++)
            {
                int currReqTickets = tickets[i];
                
                if(i <= k)
                {
                    if(currReqTickets <= targetTickets)
                        sumTime += currReqTickets;
                    else
                        sumTime += targetTickets;
                }
                else
                {
                    if(currReqTickets < targetTickets)
                        sumTime += currReqTickets;
                    else
                        sumTime += targetTickets-1;
                }
            }

            return sumTime;
        }
    }
}

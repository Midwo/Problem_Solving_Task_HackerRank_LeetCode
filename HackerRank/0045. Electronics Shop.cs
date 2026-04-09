using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0045
    {
        ////45. Electronics Shop (EASY)
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            if (keyboards.Min() + drives.Min() > b)
            {
                return -1;
            }
            else
            {
                int maxBuyValue = int.MinValue;
                foreach (int i in keyboards)
                {
                    foreach (int x in drives)
                    {
                        if (i + x <= b)
                        {
                            maxBuyValue = maxBuyValue < i + x ? i + x : maxBuyValue;
                        }

                    }
                }
                return maxBuyValue;
            }
        }
    }
}

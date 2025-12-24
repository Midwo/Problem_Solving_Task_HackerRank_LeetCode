using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2347
    {
        ////(2347.) Best Poker Hand (EASY)
        public string BestHand(int[] ranks, char[] suits)
        {
            int length = suits.Length;
            char firstSuit = suits[0];
           
            if(firstSuit == suits[1] && firstSuit == suits[2] && firstSuit == suits[3] && firstSuit == suits[4])
            {
                return "Flush";
            }    
            
            ////other options:
            int maxCard = 0;
            int[] countCard = new int[14];
            int currCard = 0;
            int maxCount = 0;

            for (int i = 0; i < length; i++)
            {
                currCard = ranks[i];
                maxCard = maxCard < currCard ? currCard : maxCard;
                countCard[currCard]++;
                maxCount = maxCount < countCard[currCard]? countCard[currCard]: maxCount; 
            }
            if (maxCount > 2)
            {
                return "Three of a Kind";
            }
            else if (maxCount == 2)
            {
                return "Pair";
            }
            else
            {
                return "High Card";
            }
        }
    }
}

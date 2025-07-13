using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2410
    {
        ////(2410.) Maximum Matching of Players With Trainers (MEDIUM)
        public int MatchPlayersAndTrainers(int[] players, int[] trainers)
        {
            Array.Sort(players);
            Array.Sort(trainers);

            int howManMatching = 0;
            int indexTrainers = 0;
            int lengthTrainers = trainers.Length;
            int currPlayerAbility = 0;

            for (int i = 0; i < players.Length; i++)
            {
                currPlayerAbility = players[i];

                while (indexTrainers < lengthTrainers)
                {
                    if (trainers[indexTrainers] >= currPlayerAbility)
                    {
                        howManMatching++;
                        indexTrainers++;
                        break;
                    }
                    else
                    {
                        indexTrainers++;
                    }
                }
            }  
           
            return howManMatching;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2660
    {
        ////(2660.) Determine the Winner of a Bowling Game (EASY)
        public int IsWinner(int[] player1, int[] player2)
        {
            int totalScorePlayer1 = TotalScoreTask2660(player1);
            int totalScorePlayer2 = TotalScoreTask2660(player2);

            return totalScorePlayer1 == totalScorePlayer2 ? 0 : totalScorePlayer1 < totalScorePlayer2 ? 2 : 1;
        }

        private int TotalScoreTask2660(int[] player)
        {
            int totalScore = 0;
            int continue2xPoints = 0;

            foreach (int score in player)
            {
                if (continue2xPoints > 0)
                {
                    continue2xPoints--;
                    totalScore += score;
                }

                totalScore += score;
                if (score == 10)
                    continue2xPoints = 2;
            }

            return totalScore;
        }
    }
}

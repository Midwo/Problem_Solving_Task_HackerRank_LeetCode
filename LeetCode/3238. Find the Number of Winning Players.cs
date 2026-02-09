using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3238
    {
        ////(3238.) Find the Number of Winning Players (EASY)
        public int WinningPlayerCount(int n, int[][] pick)
        {
            int[][] playerAndCountAllBalls = new int[n][];

            for (int i = 0; i < n; i++)
            {
                playerAndCountAllBalls[i] = new int[11];
            }

            int countWinPlayers = 0;

            for (int indexPick = 0; indexPick < pick.Length; indexPick++)
            {
                playerAndCountAllBalls[pick[indexPick][0]][pick[indexPick][1]]++;
            }

            for (int indexPlayer = 0; indexPlayer < n; indexPlayer++)
            {
                for (int indexBall = 0; indexBall < 11; indexBall++)
                {
                    if (playerAndCountAllBalls[indexPlayer][indexBall] > indexPlayer)
                    {
                        countWinPlayers++;
                        break;
                    }

                }
            }

            return countWinPlayers;
        }
    }
}

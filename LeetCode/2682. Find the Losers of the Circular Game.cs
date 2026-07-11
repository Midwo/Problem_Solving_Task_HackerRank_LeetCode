using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2682
    {
        ////(2682.) Find the Losers of the Circular Game (EASY)
        public int[] CircularGameLosers(int n, int k)
        {
            int[] scorePlayer = new int[n+1];

            int currPlayer = 1;
            scorePlayer[1] = 1;
            int steps = k;

            while (true)
            {
                currPlayer += steps;
                if (currPlayer > n)
                    currPlayer %= n;
                if (currPlayer == 0)
                    currPlayer = n;
                scorePlayer[currPlayer]++;
                if (scorePlayer[currPlayer] == 2)
                    break;
                steps += k;

            }

            List<int> losersList = new List<int>();

            for (int player = 1; player <= n; player++)
            {
                if (scorePlayer[player] == 0) 
                    losersList.Add(player);
            }

            return losersList.ToArray();
        }
    }
}

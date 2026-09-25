using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3921
    {
        ////(3921.) Score Validator (EASY)
        public int[] ScoreValidator(string[] events)
        {
            int score = 0;
            int counter = 0;

            foreach (string currEvent in events)
            {
                if (currEvent.Length == 2)
                    score++;
                else if (currEvent[0] >= '0' && currEvent[0] <= '6')
                    score += currEvent[0] - '0';
                else
                {
                    counter++;
                    if (counter == 10)
                        break;
                }
            }

            return new int[] {score, counter };
        }
    }
}

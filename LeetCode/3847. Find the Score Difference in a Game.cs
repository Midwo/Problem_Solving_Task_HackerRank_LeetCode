using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3847
    {
        ////(3847.) Find the Score Difference in a Game (MEDIUM)
        public int ScoreDifference(int[] nums)
        {
            int firstPlayerScore = 0;
            int secondPlayerScore = 0;
            bool addScoreToPlayerOne = true;

            for (int index = 0; index < nums.Length; index++)
            {
                int num = nums[index];
                
                if (num % 2 == 1)
                    addScoreToPlayerOne = !addScoreToPlayerOne;
                
                if ((index+1)%6 == 0)
                {
                    addScoreToPlayerOne = !addScoreToPlayerOne;
                }

                if(addScoreToPlayerOne)
                    firstPlayerScore += num;
                else
                    secondPlayerScore += num;
            } 

            return firstPlayerScore - secondPlayerScore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2225
    {
        ////(2225.) Find Players With Zero or One Losses (MEDIUM)
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            HashSet<int> hashsetWinners = new HashSet<int>();
            HashSet<int> hashSetOneLoses = new HashSet<int>();
            HashSet<int> hashSetTwoOrMoreLoses = new HashSet<int>();

            for (int i = 0; i < matches.Length; i++) 
            { 
                hashsetWinners.Add(matches[i][0]);
                if (!hashSetOneLoses.Add(matches[i][1]))
                {
                    hashSetTwoOrMoreLoses.Add(matches[i][1]);
                }
            }

            List<int> resultListWinners = new List<int>();
            foreach (int item in hashsetWinners) 
            {
                if (!hashSetOneLoses.Contains(item))
                {
                    resultListWinners.Add(item);
                }
            }
            List<int> resultListOneLost = new List<int>();
            foreach (int item in hashSetOneLoses)
            {
                if (!hashSetTwoOrMoreLoses.Contains(item))
                {
                    resultListOneLost.Add(item);
                }
            }

            resultListOneLost.Sort();
            resultListWinners.Sort();

            IList<IList<int>> result = new List<IList<int>>() {resultListWinners, resultListOneLost };

            return result;
        }
    }
}

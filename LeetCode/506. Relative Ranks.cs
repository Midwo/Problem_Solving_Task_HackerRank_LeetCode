using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_506
    {
        ////(506.) Relative Ranks (EASY)
        public string[] FindRelativeRanks(int[] score)
        {
            int[] sortScore = score.ToArray();
            Array.Sort(sortScore);
            int scoreLength = score.Length;
            string[] result = new string[scoreLength];
            int index = 0;
            for (int i = 0; i < scoreLength; i++)
            {
                for (int j = 0; j < scoreLength; j++)
                {
                    if (score[i] == sortScore[j])
                    {
                        index = scoreLength - j; break;
                    }
                }

                if (index <= 3)
                {
                    if (index == 1)
                    {
                        result[i] = "Gold Medal";
                    }
                    else if (index == 2)
                    {
                        result[i] = "Silver Medal";
                    }
                    else
                    {
                        result[i] = "Bronze Medal";
                    }
                    continue;
                }
                result[i] = index.ToString();
            }
            return result;
        }
    }
}

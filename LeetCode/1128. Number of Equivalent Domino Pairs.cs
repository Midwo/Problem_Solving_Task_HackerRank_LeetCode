using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1128
    {
        ////(1128.) Number of Equivalent Domino Pairs (EASY)
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            Dictionary<string, int> countDominoes = new Dictionary<string, int>();

            for (int i = 0; i < dominoes.Length; i++)
            {
                int tempValue1 = dominoes[i][0];
                int tempValue2 = dominoes[i][1];

                if (tempValue1 < tempValue2)
                {
                    string currString = tempValue1 + "," + tempValue2;
                    if (countDominoes.ContainsKey(currString))
                    {
                        countDominoes[currString]++;
                    }
                    else
                    {
                        countDominoes.Add(currString, 0);
                    }
                }
                else
                {
                    string currString = tempValue2 + "," + tempValue1;
                    if (countDominoes.ContainsKey(currString))
                    {
                        countDominoes[currString]++;
                    }
                    else
                    {
                        countDominoes.Add(currString, 0);
                    }
                }
            }

            int result = 0;

            foreach (var item in countDominoes.Values)
            {
                if(item > 0)
                {
                    result += (item + 1)*(item)/2;
                }
            }

            return result; 
        }
    }
}

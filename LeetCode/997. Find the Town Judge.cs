using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_997
    {
        ///(997.) Find the Town Judge (EASY)
        public int FindJudge(int n, int[][] trust)
        {
            Dictionary<int, int> dictionaryTrustWho = new  Dictionary<int, int>();
            Dictionary<int, int> dictionaryTrustWhom = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                dictionaryTrustWho.Add(i, 0);
                dictionaryTrustWhom.Add(i, 0);
            }

            for (int i = 0; i < trust.Length; i++)
            {
                dictionaryTrustWho[trust[i][0]] += 1;
                dictionaryTrustWhom[trust[i][1]] += 1;

            }

            int result = dictionaryTrustWho.FirstOrDefault(x => x.Value == 0).Key;
            if (result == 0)
            {
                return -1;
            }
            else
            {
                if (dictionaryTrustWhom[result] == n - 1)
                {
                    return result;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}

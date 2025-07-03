using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3304
    {
        ////(3304.) Find the K-th Character in String Game I (EASY)
        public char KthCharacter(int k)
        {
            List<int> word = new List<int> { 0 };

            while (word.Count <= k)
            {
                List<int> miniList = new List<int>();
                for (int i = 0; i < word.Count; i++)
                {     
                    miniList.Add(((int)(word[i] + 1) % 26));
                }
                word.AddRange(miniList);
            }
            return (char)(word[k-1]+'a');
        }
    }
}

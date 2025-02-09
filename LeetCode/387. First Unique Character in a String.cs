using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_387
    {
        ////(387.) First Unique Character in a String (EASY)
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dictionaryForStringS = new Dictionary<char, int>();
            int sLenght = s.Length;
            for (int i = 0; i < sLenght; i++)
            {
                if (dictionaryForStringS.ContainsKey(s[i]))
                {
                    dictionaryForStringS[s[i]]++;
                }
                else
                {
                    dictionaryForStringS.Add(s[i], 1);
                }
            }
            for (int i = 0; i < sLenght; i++)
            {
                if (dictionaryForStringS[s[i]] == 1)
                {
                    return i;
                }
            };
            return -1;
        }
    }
}

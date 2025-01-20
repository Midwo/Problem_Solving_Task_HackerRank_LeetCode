using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_205
    {
        ////(205. Isomorphic Strings) (EASY)
        public bool IsIsomorphic(string s, string t)
        {
            bool result = true;
            int lenghtStringS = s.Length;
            if (lenghtStringS != t.Length)
            {
                return false;
            }
            Dictionary<char, char> dictionaryMapping = new Dictionary<char, char>();
            for (int i = 0; i < lenghtStringS; i++)
            {
                if (dictionaryMapping.ContainsKey(s[i]))
                {
                    if (dictionaryMapping[s[i]] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (dictionaryMapping.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    dictionaryMapping.Add(s[i], t[i]);

                }
            }
            return result;
        }
    }
}

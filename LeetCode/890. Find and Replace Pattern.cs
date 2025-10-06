using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_890
    {
        ////(890.) Find and Replace Pattern (MEDIUM)
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            IList<string> result = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; i++) 
            { 
                int[] patternTest = new int[26];
                bool status = true;
                HashSet<int> hashSetInt = new HashSet<int>();

                for (int j = 0; j < pattern.Length; j++)
                {
                    int x = words[i][j];
                    int y = pattern[j];

                    if (patternTest[y - 97] == 0)
                    {
                        if (!hashSetInt.Add(x))
                        {
                            status = false;
                            break;
                        }
                        patternTest[y - 97] = x;            
                    }
                    else if (patternTest[y-97] != x) 
                    {
                        status = false;
                        break;
                    }
                }
                
                if (status)
                {
                    result.Add(words[i]);
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_455
    {
        ////(455.) Assign Cookies (EASY)
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int lengthS = s.Length;
            int currIndexS = 0;
            int currGValue;
            int result = 0;
            for (int i = 0; i < g.Length; i++)
            {
                currGValue = g[i];
                for (int j = currIndexS; j < lengthS; j++)
                {
                    if (s[j] >= currGValue)
                    {
                        ++result;
                        ++currIndexS;
                        break;
                    }
                    else
                    {
                        ++currIndexS;
                    }
                }
            }
            return result;
        }
    }
}


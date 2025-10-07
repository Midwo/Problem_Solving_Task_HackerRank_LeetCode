using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1370
    {
        ////(1370.) Increasing Decreasing String (EASY)
        public string SortString(string s)
        {
            StringBuilder sb = new StringBuilder();
            int[][] countS = new int[26][];

            for (int i = 0; i < 26; i++)
            {
                countS[i] = new int[1];
            }

            for (int i = 0; i < s.Length; i++)
            {
                countS[s[i]-97][0]++;
            }

            //int minIndex = 0;
            //int maxIndex = 25;
            int howMany = 1;
            while (howMany != 0) 
            {
                howMany = 0;
                int lastRemove = int.MinValue;
                
                for (int i = 0; i < 26; i++)
                {
                    if(lastRemove < i && countS[i][0] > 0)
                    {
                        lastRemove = i;
                        sb.Append((char)(lastRemove + 97));
                        countS[lastRemove][0]--;
                    }
                }

                lastRemove = int.MaxValue;

                for (int i = 25; i >= 0; i--)
                {
                    if (lastRemove > i && countS[i][0] > 0)
                    {
                        lastRemove = i;
                        sb.Append((char)(lastRemove + 97));
                        countS[lastRemove][0]--;
                    }
                }

                for (int i = 0; i < 26; i++)
                {
                    if (countS[i][0] > 0)
                    {
                        howMany = 1;
                        break;
                    }
                }

            }

            return new string(sb.ToString());
        }
    }
}

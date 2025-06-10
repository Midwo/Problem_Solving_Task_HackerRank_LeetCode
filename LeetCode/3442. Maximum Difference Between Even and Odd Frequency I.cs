using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3442
    {
        ////(3442.) Maximum Difference Between Even and Odd Frequency I (EASY)
        public int MaxDifference(string s)
        {
            Dictionary<char, int> dictionaryS = new Dictionary<char, int>();

            foreach (char c in s) 
            { 
                if (dictionaryS.ContainsKey(c))
                {
                    dictionaryS[c]++;
                }
                else
                {
                    dictionaryS.Add(c, 1);
                }
            }

            int minEven = int.MaxValue;
            int maxOdd = int.MinValue;
            
            foreach (var item in dictionaryS)
            {
                if(item.Value % 2 == 0)
                {
                    if (minEven > item.Value)
                    {
                        minEven = item.Value;
                    }
                }
                else
                {
                    if(maxOdd < item.Value)
                    {
                        maxOdd = item.Value;
                    }
                }
            }

            return maxOdd - minEven;
        }
    }
}

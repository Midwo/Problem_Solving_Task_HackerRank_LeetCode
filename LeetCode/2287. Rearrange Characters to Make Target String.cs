using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2287
    {
        ////(2287.) Rearrange Characters to Make Target String (EASY)
        public int RearrangeCharacters(string s, string target)
        {
            Dictionary<int, int> dictCharsCountTarget = new Dictionary<int, int>();

            for(int i = 0; i < target.Length; i++) 
            { 
                if (dictCharsCountTarget.ContainsKey(target[i]-'a'))
                {
                    dictCharsCountTarget[target[i] -'a']++;
                }
                else
                {
                    dictCharsCountTarget.Add(target[i] - 'a', 1);
                }
            }

            int[] countChar = new int[26];

            foreach(char c in s)
            {
                countChar[c - 'a']++;
            }

            int minMake = int.MaxValue;

            foreach(var item in dictCharsCountTarget)
            {
                minMake = Math.Min(minMake, countChar[item.Key] / item.Value);
            }

            return minMake;
        }
    }
}

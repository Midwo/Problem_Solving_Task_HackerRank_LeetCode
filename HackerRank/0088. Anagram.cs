using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0088
    {
        ////88. Anagram (EASY)
        public int anagram(string s)
        {
            //Solution 1 (New)
            var lengthS = s.Length;
            if ((lengthS & 1) == 1)
                return -1;

            var diffTableChars = new int[26];

            for (int i = 0; i < lengthS; i++)
            { 
                if(i < lengthS / 2)
                {
                    diffTableChars[s[i] - 'a']++;
                }
                else
                {
                    diffTableChars[s[i] - 'a']--;
                }
            }

            var countOperations = 0;

            foreach (var currValue in diffTableChars)
            {
                countOperations += currValue > 0 ? currValue : -currValue;
            }

            return countOperations / 2;

            //Solution 2 (Old)
            //if (s.Length % 2 == 1) return -1;

            //var chars = s.ToCharArray();
            //var firstString = chars.Take(chars.Length / 2).ToList();
            //var secondString = chars.Skip(chars.Length / 2).ToList();

            //for (int i = 0; i < firstString.Count; i++)
            //{
            //    if (secondString.Contains(firstString[i]))
            //        secondString.Remove(firstString[i]);
            //}
            //return secondString.Count;
        }
    }
}

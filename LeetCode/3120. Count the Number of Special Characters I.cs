using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3120
    {
        ////(3120.) Count the Number of Special Characters I (EASY)
        public int NumberOfSpecialChars(string word)
        {
            HashSet<char> upperChars = new HashSet<char>();
            HashSet<char> lowerChars = new HashSet<char>();

            foreach (char c in word) 
            { 
                if (c < 96)
                {
                    upperChars.Add(c);
                }
                else
                {
                    lowerChars.Add(c);
                }
            }

            int count = 0;

            foreach (char c in upperChars) 
            {
                //int x = 'a' - 'A';
                if (lowerChars.Contains((char)(c + 32)))
                {
                    count++;
                }
            }

            return count;
        }
    }
}

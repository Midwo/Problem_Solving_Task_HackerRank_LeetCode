using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3016
    {
        ////(3016.) Minimum Number of Pushes to Type Word II (MEDIUM)
        public int MinimumPushes(string word)
        {
            int minPushes = 0;
            int[] freqWord = new int[26];

            foreach (char currChar in word) 
            { 
                if(currChar == '1' || currChar == '*' || currChar == '#' || currChar == '0')
                {
                    minPushes++;
                }
                else
                {
                    freqWord[currChar - 'a']++;
                }
            }

            Array.Sort(freqWord);
            int multiplier = 1;
            int countKeys = 0;
            
            for (int index = 25; index >= 0; index--)
            {
                int currFreq = freqWord[index];
                if (currFreq == 0)
                    break;
                
                countKeys++;
                
                if (countKeys > 8)
                {
                    multiplier++;
                    countKeys = 1;
                }

                minPushes += multiplier * currFreq;
            }

            return minPushes;
        }
    }
}

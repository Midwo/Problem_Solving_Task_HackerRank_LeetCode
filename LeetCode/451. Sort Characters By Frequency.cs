using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_451
    {
        ////(451.) Sort Characters By Frequency (MEDIUM)
        public string FrequencySort(string s)
        {
            StringBuilder sbResult = new StringBuilder();
            int[][] freqChar = new int[62][];

            for (int i = 0; i < 62; i++)
            {
                freqChar[i] = new int[2];
            }

            foreach (char currChar in s)
            {
                if(currChar <= '9')
                {
                    int temp = currChar - '0';
                    freqChar[temp][0]++;
                    freqChar[temp][1] = currChar;
                }
                else if (currChar < 'a')
                {
                    int temp = currChar - 'A';
                    freqChar[temp+10][0]++;
                    freqChar[temp+10][1] = currChar;
                }
                else
                {
                    int temp = currChar - 'a';
                    freqChar[temp+36][0]++;
                    freqChar[temp+36][1] = currChar;
                }
            }

            freqChar = freqChar.OrderByDescending(x => x[0]).ToArray();

            for(int index = 0; index < 62; index++)
            {
                int count = freqChar[index][0];
                if(count == 0)
                    break;
                char currChar = (char)freqChar[index][1];
                sbResult.Append(currChar, count);
            }

            return sbResult.ToString();
        }
    }
}

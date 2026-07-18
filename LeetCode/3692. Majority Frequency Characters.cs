using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3692
    {
        ////(3692.) Majority Frequency Characters (EASY)
        public string MajorityFrequencyGroup(string s)
        {
            int[] countFreq = new int[26];

            foreach (char currChar in s) 
            {
                countFreq[currChar - 'a']++;
            }

            string resultString = "";
                        
            Dictionary<int, string> freqAndString = new Dictionary<int, string>();

            for (int i = 0; i < 26; i++)
            {
                int currFreq = countFreq[i];
                if (currFreq > 0)
                {
                    if (freqAndString.ContainsKey(currFreq))
                    {
                        freqAndString[currFreq] += ((char)('a' + i)).ToString();
                    }
                    else
                    {
                        freqAndString.Add(currFreq, ((char)('a' + i)).ToString());
                    }

                }
            }

            int maxGroup = 0;
            int maxFreq = 0;

            foreach (var item in freqAndString)
            {
                if(item.Value.Length > maxGroup)
                {
                    maxGroup = item.Value.Length;
                    maxFreq = item.Key;
                    resultString = item.Value;
                }
                else if(item.Value.Length == maxGroup && maxFreq < item.Key)
                {
                    maxFreq = item.Key;
                    resultString = item.Value;
                }
            }

            return resultString;

        }
    }
}

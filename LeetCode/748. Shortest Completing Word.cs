using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_748
    {
        ////(748.) Shortest Completing Word (EASY)
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            Dictionary<char, int>  charsLicensePlate = CreateDictionaryCharsLicensePlate(licensePlate);

            int maxTooSameChars = 0;
            int indexMaxShort = int.MinValue;
            int lengthMaxShort = int.MaxValue;

            for (int i = 0; i < words.Length; i++)
            {
                int currCharsMax = 0;
                Dictionary<char, int> tempDictionaryChars = CreateDictionaryCharsLicensePlate(words[i]);
                
                foreach (var item in charsLicensePlate)
                {
                    if (tempDictionaryChars.ContainsKey(item.Key))
                    {
                        if(item.Value >= tempDictionaryChars[item.Key])
                        {
                            currCharsMax += tempDictionaryChars[item.Key];
                        }
                        else
                        {
                            currCharsMax += item.Value;
                        }
                    }
                    if (currCharsMax > maxTooSameChars)
                    {
                        maxTooSameChars = currCharsMax;
                        indexMaxShort = i;
                        lengthMaxShort = words[i].Length;
                    }
                    else if(currCharsMax == maxTooSameChars)
                    {
                        if(lengthMaxShort > words[i].Length)
                        {
                            lengthMaxShort = words[i].Length;
                            indexMaxShort = i;
                        }
                    }
                }
            }

            return words[indexMaxShort];
        }
        private Dictionary<char, int> CreateDictionaryCharsLicensePlate(string textString)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < textString.Length; i++)
            {
                char temp = textString[i];
                if (temp > 64 && temp < 91)
                {
                    temp = (char)((int)temp + 32);
                }
                if (temp > 96 && temp < 123)
                {
                    if (result.ContainsKey(temp))
                    {
                        result[temp]++;
                    }
                    else
                    {
                        result.Add(temp, 1);
                    }
                }

            }
            return result;
        }
    }
}

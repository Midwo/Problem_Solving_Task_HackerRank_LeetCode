using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_811
    {
        ////(811.) Subdomain Visit Count (MEDIUM)
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> result = new List<string>();

            Dictionary<string, int> dictionaryStringCount = new Dictionary<string, int>();

            for (int i = 0; i < cpdomains.Length; i++)
            {
                string[] stringsSplit = cpdomains[i].Split(' ');
                int countValue = int.Parse(stringsSplit[0]);
                int length = stringsSplit[1].Length;
                int startIndex = 0;
                for (int j = 0; j < length; j++)
                {
                    if (stringsSplit[1][j] == '.')
                    {
                        if (dictionaryStringCount.ContainsKey(stringsSplit[1][startIndex..(length)]))
                        {
                            dictionaryStringCount[stringsSplit[1][startIndex..(length)]] += countValue;
                        }
                        else
                        {
                            dictionaryStringCount.Add(stringsSplit[1][startIndex..(length)], countValue);
                        }
                        startIndex = j + 1;
                    }
                }
                if (dictionaryStringCount.ContainsKey(stringsSplit[1][startIndex..(length)]))
                {
                    dictionaryStringCount[stringsSplit[1][startIndex..(length)]] += countValue;
                }
                else
                {
                    dictionaryStringCount.Add(stringsSplit[1][startIndex..(length)], countValue);
                }
            }

            foreach (var item in dictionaryStringCount) 
            { 
                result.Add(item.Value + " " + item.Key);            
            }

            return result;
        }
    }
}

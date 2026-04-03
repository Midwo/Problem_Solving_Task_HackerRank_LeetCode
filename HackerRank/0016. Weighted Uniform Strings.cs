using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0016
    {
        public List<string> weightedUniformStrings(string s, List<int> queries)
        {
            Dictionary<char, int> dataCharTable = new Dictionary<char, int>(){
                { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 }, { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 },
                { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 }, { 'p', 16}, { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 },
                { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 }};
            List<int> listValueFromString = new();
            int setWeight = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && s[i] == s[i + 1])
                {
                    //setWeight += s[i] - 96;
                    setWeight += dataCharTable[s[i]];
                    listValueFromString.Add(setWeight);
                }
                else
                {
                    listValueFromString.Add(setWeight + dataCharTable[s[i]]);
                    setWeight = 0;
                }
            }
            List<string> outputPrintList = new();
            for (int i = 0; i < queries.Count; i++)
            {
                if (listValueFromString.Contains(queries[i]))
                {
                    outputPrintList.Add("Yes");
                }
                else
                {
                    outputPrintList.Add("No");
                }
            }
            return outputPrintList;
        }

    }
}

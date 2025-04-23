using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1002
    {
        /////(1002.) Find Common Characters (EASY)
        public IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();

            Dictionary<char, int> firstDictionary = new Dictionary<char, int>();
            Dictionary<char, int> secondDictionary = new Dictionary<char, int>();


            for (int i = 0; i < words[0].Length; i++)
            {
                if (firstDictionary.ContainsKey(words[0][i]))
                {
                    firstDictionary[words[0][i]]++;
                }
                else
                {
                    firstDictionary.Add(words[0][i], 1);
                }
            }

            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (secondDictionary.ContainsKey(words[i][j]))
                    {
                        secondDictionary[words[i][j]]++;
                    }
                    else
                    {
                        secondDictionary.Add(words[i][j], 1);
                    }
                }
                foreach (var item in firstDictionary)
                {
                    if (secondDictionary.ContainsKey(item.Key)) 
                    {
                        int minValue = Math.Min(item.Value, secondDictionary[item.Key]);
                        firstDictionary[item.Key] = minValue;
                    }
                    else
                    {
                        firstDictionary.Remove(item.Key);
                    }
                }
                secondDictionary.Clear();
            }
            foreach(var item in firstDictionary)
            {
                int count = item.Value;
                while(count != 0)
                {
                    result.Add(item.Key.ToString());
                    count--;
                }
            }

            return result;
        }
    }
}

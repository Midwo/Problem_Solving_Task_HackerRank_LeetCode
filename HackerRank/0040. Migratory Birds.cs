using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0040
    {
        ////40. Migratory Birds (EASY)
        public int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int y = arr[i];
                if (!dictionary.ContainsKey(y))
                {
                    dictionary.Add(y, 1);
                }
                else
                {
                    int x = dictionary[y] + 1;
                    dictionary[y] = x;
                }
            }
            int howManyMax = 0;
            int howManyNow = 0;
            int keyDictionaryMinValueKey = int.MaxValue;
            int keyDictionaryNow = int.MaxValue;
            for (int xy = 0; xy < dictionary.Count; xy++)
            {
                int key = dictionary.ElementAt(xy).Key;
                howManyNow = dictionary[key];
                if (howManyMax == howManyNow)
                {
                    if (key < keyDictionaryMinValueKey)
                    {
                        keyDictionaryMinValueKey = key;
                    }
                }
                else if (howManyMax < howManyNow)
                {
                    howManyMax = howManyNow;
                    keyDictionaryMinValueKey = key;
                }
            }
            return keyDictionaryMinValueKey;
        }
    }
}

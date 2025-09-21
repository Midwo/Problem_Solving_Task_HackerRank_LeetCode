using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1079
    {
        ////(1079.) Letter Tile Possibilities (MEDIUM)

        HashSet<string> _hashsetString;
        public int NumTilePossibilities(string tiles)
        {
            ////20ms, Beats: 52.27% 
            
            Dictionary<char, int> countCharDictionary = new Dictionary<char, int>();

            for (int i = 0; i < tiles.Length; i++)
            {
                if (countCharDictionary.ContainsKey(tiles[i]))
                {
                    countCharDictionary[tiles[i]]++;
                }
                else
                {
                    countCharDictionary.Add(tiles[i], 1);
                }
            }

            _hashsetString = new HashSet<string>();

            GenerateLetterPossibilities(countCharDictionary, string.Empty);

            return _hashsetString.Count;
        }

        private void GenerateLetterPossibilities(Dictionary<char, int> countCharDictionary, string currPath)
        {
            foreach (var item in countCharDictionary)
            {
                if (item.Value == 0)
                {
                    continue;
                }
                if (countCharDictionary.Count == 0)
                {
                    return;
                }
                countCharDictionary[item.Key]--;
                currPath += item.Key;
                _hashsetString.Add(currPath);
                GenerateLetterPossibilities(countCharDictionary, currPath);
                countCharDictionary[item.Key]++;
                currPath = currPath[0..(currPath.Length - 1)];
            }
        }
    }
}

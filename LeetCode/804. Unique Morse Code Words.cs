using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_804
    {
        ////(804.) Unique Morse Code Words (EASY)
        public int UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> dictionaryMorse = new Dictionary<char, string>() 
            { 
                { 'a', ".-" }, { 'b', "-..." }, {'c', "-.-." }, {'d',"-.." }, {'e',"." }, {'f',"..-." }, {'g',"--." }, {'h',"...." },
                { 'i',".." }, {'j',".---" }, {'k',"-.-" }, {'l',".-.." }, {'m',"--" }, {'n',"-." }, {'o',"---" }, {'p',".--." }, {'q',"--.-" },
                { 'r',".-." }, {'s',"..." }, {'t',"-" }, {'u',"..-" }, {'v',"...-" }, {'w',".--" }, {'x',"-..-" }, {'y',"-.--" }, {'z',"--.." } 
            };

            HashSet<string> resultString = new HashSet<string>();

            foreach (string word in words)
            {
                string currString = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    currString += dictionaryMorse[word[i]];
                }
                resultString.Add(currString);
            }

            return resultString.Count;
        }
    }
}

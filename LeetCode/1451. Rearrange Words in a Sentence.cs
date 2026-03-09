using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1451
    {
        ////(1451.) Rearrange Words in a Sentence (MEDIUM)
        public string ArrangeWords(string text)
        {
            string[] splitText = text.Split(' ');
            splitText[0] = splitText[0].ToLower();

            splitText = splitText.OrderBy(x => x.Length).ToArray();
            splitText[0] = (char)(splitText[0][0] - 32)  + splitText[0][1..splitText[0].Length];

            return string.Join(" ", splitText);
        }
    }
}

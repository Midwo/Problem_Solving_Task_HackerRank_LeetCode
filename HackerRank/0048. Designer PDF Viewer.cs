using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0048
    {
        ////48. Designer PDF Viewer (EASY)
        public int designerPdfViewer(List<int> h, string word)
        {
            int maxValue = 0;
            int currentValue = 0;
            foreach (char letter in word)
            {
                currentValue = h[(letter) - 97];
                if (currentValue > maxValue)
                    maxValue = currentValue;
            }
            return maxValue * word.Length;
        }
    }
}

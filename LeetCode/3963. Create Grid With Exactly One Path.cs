using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3963
    {
        ////(3963.) Create Grid With Exactly One Path (EASY)
        public string[] CreateGrid(int m, int n)
        {
            string[] resultGrid = new string[m];
            char[] line = new char[n];
            Array.Fill(line, '.');

            resultGrid[0] = new string(line);

            Array.Fill(line, '#');
            line[n - 1] = '.';
            string stringLine = new string(line);
            for (int i = 1; i < m; i++) 
            {
                resultGrid[i] = stringLine;
            }

            return resultGrid;
        }
    }
}

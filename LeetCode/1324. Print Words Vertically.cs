using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1324
    {
        ////(1324.) Print Words Vertically (MEDIUM)
        public IList<string> PrintVertically(string s)
        {
            string[] splitS = s.Split(' ');

            //int maxLengthWord = splitS.Max(x => x.Length);

            //OR

            int maxLengthWord = 0;
            foreach (var word in splitS) 
            {
                if (word.Length > maxLengthWord)
                    maxLengthWord = word.Length;
            }

            IList<string> result = new List<string>();
            int rows = splitS.Length;

            for (int indexCol = 0; indexCol < maxLengthWord; indexCol++) 
            {
                StringBuilder sb = new StringBuilder();

                for (int indexRow = 0; indexRow < rows; indexRow++)
                {
                    if(indexCol < splitS[indexRow].Length)
                    {
                        sb.Append(splitS[indexRow][indexCol]);
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                result.Add(sb.ToString().TrimEnd());
            }

            return result;
        }
    }
}

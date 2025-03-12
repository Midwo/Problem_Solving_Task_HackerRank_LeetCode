using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_6
    {
        ////(6.) Zigzag Conversion (MEDIUM)
        public string Convert(string s, int numRows)
        {
            int currIndex = numRows;
            int endIndex = s.Length;
            List<string> resultList = new List<string>(numRows-1);
            bool grow = true;
            int row = numRows-1;
            if (endIndex < numRows)
            {
                numRows = endIndex;
                currIndex = endIndex;
            }
            if (numRows == 1)
            {
                return s;
            }
            for(int i = 0; i < numRows; i++)
            {
                resultList.Add(s[i].ToString());
            }

            while (currIndex != endIndex)
            {
                if (grow) 
                {
                    row--;
                    resultList[row] += s[currIndex];
                    if (row == 0)
                    {
                        grow = false;
                    }
                }
                else
                {
                    row++;
                    resultList[row] += s[currIndex]; 
                     if (row == numRows-1)
                    {
                        grow = true;
                    }
                }


                currIndex++;
            }

            return string.Join("", resultList);
        }
    }
}

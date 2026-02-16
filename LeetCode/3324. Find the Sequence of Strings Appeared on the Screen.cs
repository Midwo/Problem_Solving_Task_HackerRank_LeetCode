using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3324
    {
        ////(3324.) Find the Sequence of Strings Appeared on the Screen (MEDIUM)
        public IList<string> StringSequence(string target)
        {
            ////Solution 1:
            IList<string> resultList = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (char currChar in target)
            {
                for (char loopChar = 'a'; loopChar <= currChar; loopChar++)
                {
                    sb.Append(loopChar);
                    resultList.Add(sb.ToString());
                    sb.Length--;
                }
                sb.Append(currChar);
            }

            return resultList;


            ////Solution 2:
            //IList<string> resultList = new List<string>();
            //string currString = "";
            //foreach (char currChar in target)
            //{
            //    for (char loopChar = 'a'; loopChar <= currChar; loopChar++)
            //    {
            //        resultList.Add(currString + loopChar);
            //    }
            //    currString += currChar;
            //}

            //return resultList;

        }

    }
}

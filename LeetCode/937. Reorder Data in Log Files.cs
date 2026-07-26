using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_937
    {
        ////(937.) Reorder Data in Log Files (MEDIUM)
        public string[] ReorderLogFiles(string[] logs)
        {
            int length = logs.Length;
            List<string[]> letterLogs = new List<string[]>();
            List<string[]> digitLogs = new List<string[]>();
            string[] resultList = new string[length];

            foreach (string log in logs)
            {
                bool spaceDetect = false;
                bool letterNext = true;
                int indexDetectSpace = -1;

                for (int index = 0; index < log.Length; index++)
                {
                    char currChar = log[index];
                    if (currChar == ' ' && !spaceDetect)
                    {
                        spaceDetect = true;
                        indexDetectSpace = index;
                    }
                    else if (spaceDetect)
                    {
                        if (currChar >= '0' && currChar <= '9' && currChar >= '0')
                        {
                            letterNext = false;
                        }
                        break;
                    }
                }

                if (letterNext)
                {
                    letterLogs.Add(new string[2] { log[0..(indexDetectSpace + 1)], log[(indexDetectSpace + 1)..(log.Length)] });
                }
                else
                {
                    digitLogs.Add(new string[2] { log[0..(indexDetectSpace + 1)], log[(indexDetectSpace + 1)..(log.Length)] });
                }
            }

            letterLogs = letterLogs.OrderBy(x => x[1]).ThenBy(x => x[0]).ToList();

            int indexLog = 0;
            foreach (var log in letterLogs)
            {
                resultList[indexLog++] = log[0] + log[1];
            }

            foreach (var log in digitLogs)
            {
                resultList[indexLog++] = log[0] + log[1];
            }

            return resultList;
        }
    }
}

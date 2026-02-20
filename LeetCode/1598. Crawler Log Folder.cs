using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1598
    {
        ////(1598.) Crawler Log Folder (EASY)
        public int MinOperations(string[] logs)
        {
            int level = 0;

            foreach (string log in logs) 
            {
                if (log == "../")
                {
                    if (level > 0)
                    {
                        level--;
                    }
                }
                else if (log == "./")
                {
                    //do nothing, stay.
                }
                else
                {
                    level++;
                }
            }

            return level;
        }
    }
}

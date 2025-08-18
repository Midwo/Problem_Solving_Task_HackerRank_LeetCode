using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1678
    {
        ////(1678.) Goal Parser Interpretation (EASY)
        public string Interpret(string command)
        {
            StringBuilder sb = new StringBuilder();
            bool openSign = false;
             
            for (int i = 0; i < command.Length; i++) 
            {
                if (command[i] == 'G')
                {
                    sb.Append('G');
                }
                else if (command[i] == '(')
                {
                    openSign = true;
                }
                else if (command[i] == 'a')
                {
                    sb.Append("al");
                    openSign = false;
                    i += 2;
                }
                else
                {
                    sb.Append('o');
                }

            }

            return sb.ToString();

        }
    }
}

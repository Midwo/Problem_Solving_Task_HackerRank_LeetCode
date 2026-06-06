using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1576
    {
        ////(1576.) Replace All ?'s to Avoid Consecutive Repeating Characters (EASY)
        public string ModifyString(string s)
        {
            int length = s.Length;
            var resultTextTable = new char[length];

            for (int i = 0; i < length; i++)
            {
                if (s[i] == '?')
                {
                    if (i == 0)
                    {
                        if (length == 1)
                        {
                            resultTextTable[i] = 'a';
                        }
                        else
                        {
                            if (s[i + 1] != 'a')
                                resultTextTable[i] = 'a';
                            else
                                resultTextTable[i] = 'b';
                        }
                    }
                    else if (i < length - 1)
                    {
                        if (resultTextTable[i - 1] != 'a' && s[i + 1] != 'a')
                            resultTextTable[i] = 'a';
                        else if (resultTextTable[i - 1] != 'b' && s[i + 1] != 'b')
                            resultTextTable[i] = 'b';
                        else
                            resultTextTable[i] = 'c';
                    }
                    else
                    {
                        if (resultTextTable[i - 1] != 'a')
                            resultTextTable[i] = 'a';
                        else
                            resultTextTable[i] = 'b';
                    }
                }
                else
                {
                    resultTextTable[i] = s[i];
                }
            }

            return new string(resultTextTable);
        }
    }
}

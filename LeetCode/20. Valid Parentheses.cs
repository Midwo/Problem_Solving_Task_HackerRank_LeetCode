using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_20
    {
        ////(20.) Valid Parentheses (EASY)
        public bool IsValid(string s)
        {
            var x = s.ToList();
            bool endloop = false;
            Dictionary<char, char> dictionaryChar = new Dictionary<char, char>()
            {
                { '(',')' }, {'[',']'}, {'{','}'}
            };

            do
            {
                endloop = true;
                for (int i = 0; i < x.Count() - 1; i++)
                {
                    if (dictionaryChar.ContainsKey(x[i]))
                    {
                        if (dictionaryChar[x[i]] == x[i + 1])
                        {
                            x.RemoveAt(i + 1);
                            x.RemoveAt(i);
                            endloop = false;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (!endloop);

            if (x.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0007
    {
        public string Happy_ladybugs(string b)
        {
            //b = "RBY_YBR";
            Dictionary<int, int> dictionaryString = new Dictionary<int, int>();
            int howManyChar95 = 0;
            int howManyOtherChar = 0;
            int howLongString = b.Length;
            char firstChar = b[0];
            char nextChar = b[0];
            int twoWrongValues = 0;

            foreach (char s in b)
            {
                if (s != 95)
                {
                    howManyOtherChar++;
                    if (dictionaryString.ContainsKey(s))
                    {
                        dictionaryString[s]++;
                    }
                    else
                    {
                        dictionaryString.Add(s, 1);
                    }
                }
                else
                {
                    howManyChar95++;
                }
            }

            if (dictionaryString.ContainsValue(1))
            {
                return "NO";
            }
            else
            {
                if (howManyChar95 > 0)
                {
                    return "YES";
                }
                else
                {
                    for (int i = 1; i < b.Length; i++)
                    {
                        nextChar = b[i];
                        if (firstChar == nextChar)
                        {
                            firstChar = b[i];
                            twoWrongValues = 0;
                        }
                        else
                        {
                            firstChar = b[i];
                            twoWrongValues++;
                            if (twoWrongValues >= 2)
                            {
                                return "NO";
                            }
                        }
                    }
                    if (twoWrongValues < 2)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
        }

    }
}

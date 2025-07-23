using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1717
    {
        ////(1717.) Maximum Score From Removing Substrings (MEDIUM)
        public int MaximumGain(string s, int x, int y)
        {
            //x = 'ab'
            //y = 'ba'
            bool betterY = false;
            int sum = 0;

            int countA = 0;
            int countB = 0;

            Stack<char> stackChars = new Stack<char>();
            bool nextCheck = true;

            if (y > x)
            {
                betterY = true;
            }

            char temp = 'c';

            if (betterY)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == 'b')
                    {
                        stackChars.TryPeek(out temp);
                        if ('a' == temp)
                        {
                            sum += y;
                            stackChars.Pop();
                        }
                        else
                        {
                            stackChars.Push(s[i]);
                        }
                    }
                    else
                    {
                        stackChars.Push(s[i]);
                    }
                }

                while (stackChars.Count > 0)
                {
                    temp = stackChars.Pop();
                    if (temp == 'a')
                    {
                        countA++;
                    }
                    else if (temp == 'b')
                    {
                        if (countA > 0)
                        {
                            sum += x;
                            countA--;
                        }
                    }
                    else
                    {
                        countA = 0;
                    }
                }
            }
            else
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == 'a')
                    {
                        stackChars.TryPeek(out temp);
                        if ('b' == temp)
                        {
                            sum += x;
                            stackChars.Pop();
                        }
                        else
                        {
                            stackChars.Push(s[i]);
                        }
                    }
                    else
                    {
                        stackChars.Push(s[i]);
                    }
                }

                while (stackChars.Count > 0)
                {
                    temp = stackChars.Pop();
                    if (temp == 'b')
                    {
                        countB++;
                    }
                    else if (temp == 'a')
                    {
                        if (countB > 0)
                        {
                            sum += y;
                            countB--;
                        }
                    }
                    else
                    {
                        countB = 0;
                    }
                }

            }

            return sum;

        }
    }
}

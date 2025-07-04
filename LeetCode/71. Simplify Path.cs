using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_71
    {
        ////(71.) Simplify Path (MEDIUM)
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            int countDot = 0;
            
            foreach (var item in path.Split('/'))
            {
                //Console.WriteLine(item);
                if (item.Length > 0)
                {
                    if (item[0] != '/' && item[0] != '.')
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        countDot = 0;
                        for (int i = 0; i < item.Length; i++) 
                        {
                            if (item[i] == '.')
                            {
                                countDot++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (countDot == 2 && item.Length == countDot)
                        {
                            if (stack.Count > 0)
                            {
                                stack.Pop();
                            }
                        }
                        else if (countDot > 2 && item.Length == countDot)
                        {
                            string temp = string.Concat(Enumerable.Repeat(".", countDot));
                            stack.Push(temp);
                        }
                        else if (countDot < item.Length)
                        {
                            stack.Push(item);
                        }
                    }
                }
            }

            return "/" + string.Join('/',stack.Reverse());
        }

    }
}

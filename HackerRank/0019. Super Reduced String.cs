using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0019
    {
        public string superReducedString1(string s)
        {
            Stack<char> myStack = new Stack<char>();

            foreach (char c in s)
            {
                if (myStack.Count == 0)
                    myStack.Push(c);
                else
                {
                    if (c == myStack.Peek())
                        myStack.Pop();
                    else
                        myStack.Push(c);
                }
            }

            string myString = String.Join("", myStack.Reverse());

            return String.IsNullOrEmpty(myString) ? "Empty String" : myString;
        }

    }
}

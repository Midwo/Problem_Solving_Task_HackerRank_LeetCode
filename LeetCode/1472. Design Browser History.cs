using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1472
    {
        ////(1472.) Design Browser History (MEDIUM)
        public class BrowserHistory
        {
            Stack<string> _forwardStack = new Stack<string>();
            Stack<string> _backStack = new Stack<string>();
            public BrowserHistory(string homepage)
            {
                _backStack.Push(homepage);
            }

            public void Visit(string url)
            {
                _backStack.Push(url);
                _forwardStack.Clear();
            }

            public string Back(int steps)
            {
                if (_backStack.Count > 1)
                {
                    if (_backStack.Count < steps)
                    {
                        steps = _backStack.Count - 1;
                    }
                    for (int i = 0; i < steps - 1; i++)
                    {
                        _forwardStack.Push(_backStack.Pop());
                    }
                    if (_backStack.Count != 1)
                    {
                        _forwardStack.Push(_backStack.Pop());
                    }
                }
                return _backStack.Peek();
            }

            public string Forward(int steps)
            {
                if (_forwardStack.Count > 0)
                {
                    if (steps > _forwardStack.Count)
                    {
                        steps = _forwardStack.Count;
                    }
                    for (int i = 0; i < steps - 1; i++)
                    {
                        _backStack.Push(_forwardStack.Pop());
                    }
                    _backStack.Push(_forwardStack.Pop());
                }
                return _backStack.Peek();
            }
        }
    }
}

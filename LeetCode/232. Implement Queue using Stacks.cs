using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_232
    {
        ////232. Implement Queue using Stacks (EASY)
        public class LeetCode_232_MyQueue
        {
            Queue<int> queueStacks;
            public LeetCode_232_MyQueue()
            {
                queueStacks = new Queue<int>();
            }

            public void Push(int x)
            {
                queueStacks.Enqueue(x);
            }

            public int Pop()
            {
                var x = queueStacks.Dequeue();
                return x;
            }

            public int Peek()
            {
                var x = queueStacks.Peek();
                return x;
            }

            public bool Empty()
            {
                if (queueStacks.Count == 0) {
                    return true;
                };
                return false;
            }
        }
    }
}

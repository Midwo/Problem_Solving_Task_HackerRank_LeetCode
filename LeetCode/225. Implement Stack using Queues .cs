using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ProblemSolving.LeetCode.LeetCode_225;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_225
    {
        ////(225.) Implement Stack using Queues (EASY)
        public class LeetCode_225_MyStack
        {

            //void push(int x) Pushes element x to the top of the stack.
            //int pop() Removes the element on the top of the stack and returns it.
            //int top() Returns the element on the top of the stack.
            //boolean empty() Returns true if the stack is empty, false otherwise.

            Queue<int> stackUsingQueues;

            public LeetCode_225_MyStack()
            {
                stackUsingQueues = new Queue<int>();
            }

            public void Push(int x)
            {
                stackUsingQueues.Enqueue(x);
                int sizeStackUsingQueues = stackUsingQueues.Count;
                while(sizeStackUsingQueues-- > 1)
                {
                    //sizeStackUsingQueues--;
                    int returnValueOnStack = stackUsingQueues.Dequeue();
                    stackUsingQueues.Enqueue(returnValueOnStack);
                }
            }

            public int Pop()
            {
                return stackUsingQueues.Dequeue();
            }

            public int Top()
            {
                return stackUsingQueues.Peek();
            }

            public bool Empty()
            {
                return stackUsingQueues.Count == 0;
            }
        }

    }
}

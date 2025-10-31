using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1441
    {
        ////(1441.) Build an Array With Stack Operations (MEDIUM)
        public IList<string> BuildArray(int[] target, int n)
        {
            ////Solution #1
            ///0ms
            
            List<string> resultList = new List<string>();
            int index = 0;
            for (int i = 1; i <= n && index < target.Length; i++)
            {
                if (i == target[index])
                {
                    resultList.Add("Push");
                    index++;
                }
                else
                {
                    resultList.Add("Push");
                    resultList.Add("Pop");
                }
            }

            return resultList;

            ////Solution #2 
            ///1ms
            
            //Stack<int> intsStack = new Stack<int>();
            //intsStack.Push(1);
            //int length = target.Length;
            //IList<string> resultList = new List<string>();
            ////Console.WriteLine(intsStack.Peek());
            //int indexTarget = 0;
            //bool newValue = false;
            //int currValuePop = 0;
            //int currFirstValue = 1;

            //if (target[0] != currFirstValue)
            //{
            //    resultList.Add("Push");
            //    while (target[0] != currFirstValue)
            //    {
            //        resultList.Add("Pop");
            //        currFirstValue++;
            //        resultList.Add("Push");
            //    }
            //    if (intsStack.Peek() != currFirstValue)
            //    {
            //        intsStack.Pop();
            //        intsStack.Push(currFirstValue);
            //    }
            //    indexTarget++;
            //    newValue = true;
            //} 
            //else if (length == 1)
            //{
            //    resultList.Add("Push");
            //}
            //while (intsStack.Peek() != target[length - 1])
            //{
            //    if (newValue)
            //    {
            //        resultList.Add("Push");
            //        if (currValuePop > intsStack.Peek() + 1)
            //        {
            //            intsStack.Push(currValuePop);
            //        }
            //        else
            //        {
            //            intsStack.Push(intsStack.Peek() + 1);
            //        }
            //        if (target[indexTarget] == intsStack.Peek())
            //        {
            //            indexTarget++;
            //        }
            //        else
            //        {
            //            newValue = false;
            //        }
            //    }
            //    else
            //    {
            //        if (target[indexTarget] == intsStack.Peek())
            //        {
            //            indexTarget++;
            //            resultList.Add("Push");
            //            newValue = true;
            //        }
            //        else
            //        {
            //            currValuePop = intsStack.Pop() + 1;
            //            resultList.Add("Pop");
            //            newValue = true;
            //        }
            //    }
            //}
            //return resultList;
        }
    }
}

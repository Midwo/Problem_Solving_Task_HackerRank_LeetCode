using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3798
    {
        ////(3798.) Largest Even Number (EASY)
        public string LargestEven(string s)
        {
            int length = s.Length;
            for (int index = length - 1; index >= 0; index--) 
            {
                if (s[index] == '2')
                {
                    return s[0..(index+1)];
                }
            }

            return "";

            ////extended version, fun
            //PriorityQueue<int, int> priorityQueueEven = new PriorityQueue<int, int>();
            //PriorityQueue<int, int> priorityQueueOdd = new PriorityQueue<int, int>();

            //foreach (var currChar in s)
            //{
            //    int currValue = currChar - '0';

            //    if (currValue % 2 == 0)
            //        priorityQueueEven.Enqueue(currValue, currValue);
            //    else
            //        priorityQueueOdd.Enqueue(currValue, currValue);
            //}

            //if (priorityQueueEven.Count == 0)
            //    return "";

            //string resultString = priorityQueueEven.Dequeue().ToString();

            //while (priorityQueueEven.Count != 0 || priorityQueueOdd.Count != 0)
            //{
            //    if (priorityQueueEven.Count == 0)
            //    {
            //        resultString = priorityQueueOdd.Dequeue().ToString() + resultString;
            //    }
            //    else if (priorityQueueOdd.Count == 0)
            //    {
            //        resultString = priorityQueueEven.Dequeue().ToString() + resultString;
            //    }
            //    else
            //    {
            //        if (priorityQueueEven.Peek() > priorityQueueOdd.Peek())
            //        {
            //            resultString = priorityQueueOdd.Dequeue().ToString() + resultString;
            //        }
            //        else
            //        {
            //            resultString = priorityQueueEven.Dequeue().ToString() + resultString;
            //        }
            //    }
            //} 

            //return resultString;
        }
    }
}

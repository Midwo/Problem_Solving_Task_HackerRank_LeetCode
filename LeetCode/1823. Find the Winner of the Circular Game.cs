using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1823
    {
        ////(1823.) Find the Winner of the Circular Game (MEDIUM)
        public int FindTheWinner(int n, int k)
        {
            Queue<int> ints = new Queue<int>();

            for (int i = 1; i <= n; i++)
            {
                ints.Enqueue(i);
            }

            int currNext = 0;
            while (ints.Count > 1)
            {
                int temp = ints.Dequeue();
                currNext++;
                if (currNext == k)
                {
                    currNext = 0;
                }
                else
                {
                    ints.Enqueue(temp);
                }
            }

            return ints.Dequeue();
        }
    }
}

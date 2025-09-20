using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_950
    {
        ////(950.) Reveal Cards In Increasing Order (MEDIUM)
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            //// 4ms, Beats: 95.24%

            int length = deck.Length;
            Array.Sort(deck);
            int[] newDeck = new int[length];
            Queue<int> queue = new Queue<int>();
            
            for (int i = 0; i < length; i++)
            {
                queue.Enqueue(i);
            }

            int index = 0;
            
            while (queue.Count > 0)
            {
                newDeck[queue.Dequeue()] = deck[index++];  
                if (queue.Count == 0)
                {
                    break;
                }
                int temp = queue.Dequeue();
                queue.Enqueue(temp);
            }

            return newDeck;
        }
    }
}

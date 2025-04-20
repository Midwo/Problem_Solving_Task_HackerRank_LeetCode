using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_914
    {
        ////(914.) X of a Kind in a Deck of Cards (EASY)
        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> dictionaryDeck = new Dictionary<int, int>();
           
            if (deck.Length < 2) 
            {
                return true;
            }

            for (int i = 0; i < deck.Length; i++)
            {
                if (!dictionaryDeck.ContainsKey(deck[i]))
                {
                    dictionaryDeck.Add(deck[i], 1);
                }
                else
                {
                    dictionaryDeck[deck[i]]++;
                }
            }

            int minDeck = int.MaxValue;

            foreach (var item in dictionaryDeck)
            {
                if(item.Value < minDeck)
                {
                    minDeck = item.Value;
                }
            }

            for(int i = 2; i <= minDeck; i++)
            {
                bool tempBool = true;
                foreach (var item in dictionaryDeck)
                {
                    if (item.Value % i != 0)
                    {
                        tempBool = false;
                        break;
                    }
                }
                if(tempBool == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

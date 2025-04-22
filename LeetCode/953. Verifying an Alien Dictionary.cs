using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_953
    {
        ////(953.) Verifying an Alien Dictionary (EASY)
        public bool IsAlienSorted(string[] words, string order)
        {
            ////["word", "world", "row"];

            int countWords = words.Length;
  
            for (int i = 0; i < countWords-1; i++)
            {
                int tempLength0 = words[i].Length;
                int tempLength1 = words[i+1].Length;
                int maxLengthWord = Math.Max(tempLength0, tempLength1);
                
                for (int j = 0; j < maxLengthWord; j++)
                {
                    if (tempLength0-1 < j) 
                    {
                        break;
                    }
                    else if (tempLength1-1 < j && tempLength1 < tempLength0)
                    {
                        return false;
                    }
                    
                    if (order.IndexOf(words[i][j]) > order.IndexOf(words[i+1][j]))
                    {
                        return false;
                    }
                    else if (order.IndexOf(words[i][j]) < order.IndexOf(words[i + 1][j]))
                    {
                        break;
                    }
                }
            }
   
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1935
    {
        ////(1935.) Maximum Number of Words You Can Type (EASY)
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            //HashSet<char> brokenLettersCharsList = brokenLetters.ToHashSet();
            HashSet<char> brokenLettersCharsList = new HashSet<char>();

            foreach (char currChar in brokenLetters) 
            {
                brokenLettersCharsList.Add(currChar);
            }

            int count = 0;
            bool goodValidation = true;

            foreach (char currChar in text)
            {
                if (currChar == ' ')
                {
                    if (goodValidation)
                    {
                        count++;
                    }
                    goodValidation = true;
                }
                else if (brokenLettersCharsList.Contains(currChar))
                {
                    goodValidation = false;
                }
            }
        
            if(goodValidation == true)
            {
                count++;
            }

            return count;
        }
    }
}

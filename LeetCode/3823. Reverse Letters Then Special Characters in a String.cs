using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3823
    {
        ////(3823.) Reverse Letters Then Special Characters in a String (EASY)
        public string ReverseByType(string s)
        {
            int length = s.Length;
            char[] reverseString = new char[length];
            List<char> letterList = new List<char>();
            List<char> specialCharsList = new List<char>();

            foreach (char currChar in s) 
            {
                if (currChar >= 'a' && currChar <= 'z')
                    letterList.Add(currChar);
                else
                    specialCharsList.Add(currChar);
            }

            int rIndexLetter = letterList.Count-1;
            int rIndexSpecial = specialCharsList.Count-1;
            int currIndex = 0;

            foreach(char currChar in s)
            {
                if (currChar >= 'a' && currChar <= 'z')
                    reverseString[currIndex] = letterList[rIndexLetter--];
                else
                    reverseString[currIndex] = specialCharsList[rIndexSpecial--];
                currIndex++;
            }

            return new string(reverseString);
        }
    }
}

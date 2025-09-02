using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1415
    {
        ////(1415.) The k-th Lexicographical String of All Happy Strings of Length n (MEDIUM)

        List<string> _happyStrings;
        char[] _charsABC;
        public string GetHappyString(int n, int k)
        {
            int checkRange = 3;
            _happyStrings = new List<string>();
            _charsABC = new char[3] { 'a', 'b', 'c' };
            
            for (int i = 1; i < n; i++)
            {
                checkRange *= 2;
            }

            if (checkRange < k)
            {
                return "";
            }

            GenerateHappyString(n, "");

            return _happyStrings[k-1];
        }

        private void GenerateHappyString(int length, string currString)
        {
            if (length == currString.Length) 
            {
                _happyStrings.Add(currString);
                return;
            }

            foreach (char c in _charsABC) 
            { 
                if (currString.Length > 0 && c == currString[currString.Length - 1]) { continue; }

                GenerateHappyString(length, currString+c);
            }
        }

    }
}

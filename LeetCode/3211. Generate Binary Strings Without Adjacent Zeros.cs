using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3211
    {
        private IList<string> _stringsList;
        public IList<string> ValidStrings(int n)
        {
            _stringsList = new List<string>();
            char[] chars = new char[n];
      
            GenerateString(n, 0, chars, 'z');
            return _stringsList;
        }

        private void GenerateString(int length, int currLength, char[] chars, char lastChar)
        {
            if (currLength > length - 1)
            {
                _stringsList.Add(new string(chars));
                return;
            }

            if (lastChar == '0')
            {
                chars[currLength] = '1';
                GenerateString(length, currLength + 1, chars, lastChar = chars[currLength]);
            }
            else
            {
                chars[currLength] = '0';
                GenerateString(length, currLength + 1, chars, lastChar = chars[currLength]);
                chars[currLength] = '1';
                GenerateString(length, currLength + 1, chars, lastChar = chars[currLength]);
            }
        }
    }
}

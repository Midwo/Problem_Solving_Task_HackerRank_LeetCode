using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1625
    {
        ////(1625.) Lexicographically Smallest String After Applying Operations (MEDIUM)
        public string FindLexSmallestString(string s, int a, int b)
        {
            Queue<String> queue = new Queue<string>();
            queue.Enqueue(s);

            HashSet<String> hashSetVisited = new HashSet<string>();
            hashSetVisited.Add(s);

            String smallestString = s;

            int length = s.Length;

            while (queue.Count != 0)
            {
                String currentString = queue.Dequeue();

                if (smallestString.CompareTo(currentString) > 0)
                {
                    smallestString = currentString;
                }

                char[] charArray = currentString.ToCharArray();

                for (int i = 1; i < length; i += 2)
                {
                    charArray[i] = (char)(((charArray[i] - '0' + a) % 10) + '0');
                }

                String newString = new string(charArray);
                String rotateString = currentString.Substring(length - b) + currentString.Substring(0, length - b);

                if (hashSetVisited.Add(newString))
                {
                     queue.Enqueue(newString);
                }
                if (hashSetVisited.Add(rotateString))
                {
                    queue.Enqueue(rotateString);
                }
            }

            return smallestString;
        }
    }
}

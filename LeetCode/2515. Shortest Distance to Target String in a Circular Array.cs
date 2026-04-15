using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2515
    {
        ////(2515.) Shortest Distance to Target String in a Circular Array (EASY)
        public int ClosestTarget(string[] words, string target, int startIndex)
        {
            var length = words.Length;
            var minDistance = int.MaxValue;

            for (var i = 0; i < length; i++)
            {
                if (words[i] == target)
                {
                    var generalDistance = Math.Abs(i - startIndex);
                    var otherDistance = length - generalDistance;
                    minDistance = Math.Min(minDistance, Math.Min(generalDistance, otherDistance));
                }
            }

            return minDistance == int.MaxValue ? -1 : minDistance;
        }
    }
}

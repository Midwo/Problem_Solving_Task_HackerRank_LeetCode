using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3597
    {
        ////(3597.) Partition String (MEDIUM)
        public IList<string> PartitionString(string s)
        {
            List<string> listPatritionString = new List<string>();
            HashSet<string> uniqueString = new HashSet<string>();

            string currString = string.Empty;

            for (int index = 0; index < s.Length; index++)
            {
                currString += s[index];

                if (uniqueString.Add(currString))
                {
                    listPatritionString.Add(currString);
                    currString = string.Empty;
                }
            }

            return listPatritionString;
        }
    }
}

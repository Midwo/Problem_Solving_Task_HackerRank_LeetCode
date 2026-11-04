using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3803
    {
        ////(3803.) Count Residue Prefixes (EASY)
        public int ResiduePrefixes(string s)
        {
            bool[] charVisited = new bool[26];
            int countDistinctVisited = 0;
            int countResiduePrefix = 0;

            for(int index = 0; index < s.Length; index++)
            {
                int numberChar = s[index] - 'a';

                if (!charVisited[numberChar])
                {
                    countDistinctVisited++;
                    charVisited[numberChar] = true;
                }

                if((index+1) % 3 == countDistinctVisited)
                    countResiduePrefix++;
            }

            return countResiduePrefix;
        }
    }
}

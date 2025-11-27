using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1704
    {
        ////(1704.) Determine if String Halves Are Alike (EASY)
        public bool HalvesAreAlike(string s)
        {
            HashSet<char> sets = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int lenght = s.Length;
            int diff = lenght / 2;
            int countFirstSector = 0;
            int countSecondSector = 0;

            for (int i = 0; i < diff; i++)
            {
                if (sets.Contains(s[i]))
                {
                    countFirstSector++;
                }
                if (sets.Contains(s[i + diff]))
                {
                    countSecondSector++;
                }
            }

            if(countFirstSector != countSecondSector)
            {
                return false;
            }
            return true;
        }
    }
}

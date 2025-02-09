using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_383
    {
        ////(383.) Ransom Note (EASY)
        public bool CanConstruct(string ransomNote, string magazine)
        {
            char[] ransomNoteChar = ransomNote.ToCharArray();
            char[] magazineChar = magazine.ToCharArray();
            bool result = false;
            Array.Sort(ransomNoteChar);
            Array.Sort(magazineChar);
            int currMagazineIndex = 0;
            int magazineCharCount = magazineChar.Count();
            for (int i = 0; i < ransomNoteChar.Count(); i++)
            {
                if (currMagazineIndex == magazineCharCount)
                {
                    return false;
                }
                for (int j = currMagazineIndex; j < magazineCharCount; j++)
                {
                    if ((int)ransomNoteChar[i] == (int)magazineChar[j])
                    {
                        result = true;
                        currMagazineIndex++;
                        break;
                    }
                    else if ((int)ransomNoteChar[i] < (int)magazineChar[j])
                    {
                        result = false;
                        goto EndOfLoop;
                    }
                    currMagazineIndex++;
                    result = false;
                }
                if (result == false)
                {
                    return false;
                }
            }
            EndOfLoop:
            return result;
        }
    }
}

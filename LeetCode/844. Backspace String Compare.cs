using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_844
    {
        ////(844.) Backspace String Compare (EASY)
        public bool BackspaceCompare(string s, string t)
        {
            string newString = string.Empty;
            int lenghtS = s.Length;
            int lengthT = t.Length;
            bool result = false;

            if (lenghtS >= lengthT)
            {
                result = BackspaceCompareChangeSOnT(s, t, lenghtS, lengthT);
            }
            else
            {
                result = BackspaceCompareChangeSOnT(t, s, lengthT, lenghtS);
            }

            return result;
        }

        private bool BackspaceCompareChangeSOnT(string s, string t, int lengthS, int lengthT)
        {
            string newString = string.Empty;
            bool result = false;

            string sbS = string.Empty;
            string sbT = string.Empty;
            int indexS = 0;
            int indexT = 0; 
            for (int i = 0; i < lengthS; i++)
            {
                if(i < lengthT)
                {
                    if (t[i] == '#')
                    {
                        if (indexT < 2)
                        {
                            indexT = 0;
                            sbT = string.Empty;
                        }
                        else
                        {
                            sbT = sbT.Remove(indexT - 1, 1);
                            indexT -= 1;
                        }
                    }
                    else
                    {
                        sbT += t[i];
                        indexT++;
                    }
                }
                if (s[i] == '#')
                {
                    if (indexS < 2)
                    {
                        indexS = 0;
                        sbS = string.Empty;
                    }
                    else
                    {
                        sbS = sbS.Remove(indexS - 1, 1);
                        indexS -= 1;
                    }
                }
                else
                {
                    sbS += s[i];
                    indexS++;
                }
            } 
            if (sbS == sbT)
            {
                return true;
            }

            return result;
        }
    }
}

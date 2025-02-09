using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_389
    {
        ////(389.) Find the Difference (EASY)
        public char FindTheDifference(string s, string t)
        {
            //char[] charsStringS = s.ToCharArray();
            //char[] charsStringT = t.ToCharArray();

            //Array.Sort(charsStringS);
            //Array.Sort(charsStringT);
            //int sLenght = s.Length;

            //if (sLenght == 0) 
            //{
            //    return charsStringT[0];
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (charsStringS[i] != charsStringT[i])
            //    {
            //        return charsStringT[i];
            //    }
            //}
            //return charsStringT[sLenght];

            ////OR SUM ASCI (Better Runtime, Worse Memory)
            int sumASCIforStringS = 0;
            int sumASCIforStringT = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                sumASCIforStringS += s[i];
            }
            for (int i = 0; i < t.Length; i++)
            {
                sumASCIforStringT += t[i];
            }
            return (char)(sumASCIforStringT - sumASCIforStringS);
        }
    }
}

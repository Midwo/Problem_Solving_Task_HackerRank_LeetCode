using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3941
    {
        ////(3941.) Password Strength (MEDIUM)

        //Solution 1 - better
        public int PasswordStrength(string password)
        {
            bool[] statusASCII = new bool[128];

            foreach (char currChar in password)
            {
                statusASCII[currChar] = true;
            }

            int strengthPassword = 0;

            for (char currChar = 'a'; currChar <= 'z'; currChar++)
            {
                if (statusASCII[currChar])
                    strengthPassword++;
            }

            for (char currChar = 'A'; currChar <= 'Z'; currChar++)
            {
                if (statusASCII[currChar])
                    strengthPassword += 2;
            }

            for (char currChar = '0'; currChar <= '9'; currChar++)
            {
                if (statusASCII[currChar])
                    strengthPassword += 3;
            }

            strengthPassword += statusASCII['!'] == true ? 5 : 0;
            strengthPassword += statusASCII['@'] == true ? 5 : 0;
            strengthPassword += statusASCII['#'] == true ? 5 : 0;
            strengthPassword += statusASCII['$'] == true ? 5 : 0;


            return strengthPassword;
        }



        //Solution 2 - worst
        //public int PasswordStrength(string password)
        //{
        //    HashSet<char> lowerCaseLetters = new HashSet<char>();
        //    HashSet<char> upperCaseLetters = new HashSet<char>();
        //    HashSet<char> digits = new HashSet<char>();
        //    HashSet<char> specialCharacters = new HashSet<char>();

        //    foreach (char currChar in password)
        //    {
        //        if (currChar >= 'a' && currChar <= 'z')
        //            lowerCaseLetters.Add(currChar);
        //        else if (currChar >= 'A' && currChar <= 'Z')
        //            upperCaseLetters.Add(currChar);
        //        else if (currChar >= '0' && currChar <= '9')
        //            digits.Add(currChar);
        //        else
        //            specialCharacters.Add(currChar);
        //    }

        //    return lowerCaseLetters.Count + upperCaseLetters.Count * 2 + digits.Count * 3 + specialCharacters.Count * 5;
        //}
    }
}

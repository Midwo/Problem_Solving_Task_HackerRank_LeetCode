using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_925
    {
        ////(925.) Long Pressed Name (EASY)
        public bool IsLongPressedName(string name, string typed)
        {
            int lengthName = name.Length;
            int lengthTyped = typed.Length;
            char prevChar = name[0];
            char currChar = name[0];
            int indexNumber = 0;
            bool result = false;

            if (currChar != typed[0])
            {
                return false;
            }

            for (int i = 0; i < lengthTyped; i++)
            {
                char tempChar = typed[i];
                if(currChar == typed[i])
                {
                    prevChar = currChar;
                    indexNumber++;
                    if (indexNumber == lengthName)
                    {
                        indexNumber--;
                        result = true;
                    }
                    currChar = name[indexNumber];
                }
                else if (tempChar == prevChar)
                {

                }
                else
                {
                    prevChar = name[0];
                    currChar = name[0];
                    indexNumber = 0;
                    result = false;
                }
            }

            return result;
        }
    }
}

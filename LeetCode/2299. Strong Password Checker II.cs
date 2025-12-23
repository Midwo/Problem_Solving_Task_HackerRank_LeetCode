using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2299
    {
        ////(2299.) Strong Password Checker II (EASY)
        public bool StrongPasswordCheckerII(string password)
        {
            int length = password.Length;
            bool[] statusOptions = new bool[4];
            
            if (length > 7)
            {
                char lastChar = ' ';

                for (int i = 0; i < length; i++)
                {
                    if (lastChar == password[i]) 
                    {
                        return false;
                    }
                    else
                    {
                        lastChar = password[i];
                        
                        if (lastChar >= 'a' && lastChar <= 'z')
                        {
                            statusOptions[0] = true;
                        }
                        else if (lastChar >= 'A' && lastChar <= 'Z')
                        {
                            statusOptions[1] = true;
                        }
                        else if (lastChar >= '0' && lastChar <= '9')
                        {
                            statusOptions[2] = true;
                        }
                        else if ("!@#$%^&*()-+".IndexOf(lastChar) >= 0)
                        {
                            statusOptions[3] = true;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

            if (statusOptions[0] && statusOptions[1] && statusOptions[2] && statusOptions[3])
            {
                return true;
            } 

            return false;
        }
    }
}

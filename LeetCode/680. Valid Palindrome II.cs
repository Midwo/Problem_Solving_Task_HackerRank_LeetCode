using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_680
    {
        ////(680.) Valid Palindrome II (EASY)
        public bool ValidPalindrome(string s)
        {
            int leftIndex = 0;
            int rightIndex = s.Length-1;
            bool boolDeleting = false;
             
            while(leftIndex < rightIndex)
            {
                if (s[leftIndex] == s[rightIndex]) 
                {
                    leftIndex++;
                    rightIndex--;
                }
                else
                {
                    if (boolDeleting)
                    {
                        return false;
                    }
                    if(s[leftIndex+1] == s[rightIndex])
                    {
                        int currLeft = leftIndex + 1;
                        int currRigt = rightIndex;
                        bool currFalse = false;
                        while (currLeft < currRigt)
                        {
                            if (s[currLeft] == s[currRigt])
                            {
                                currLeft++;
                                currRigt--;
                            }
                            else
                            {
                                currFalse = true;
                                break;
                            }
                        }
                        if (currFalse)
                        {
                            if ((s[leftIndex] == s[rightIndex - 1]))
                            {
                                
                                boolDeleting = true;
                                rightIndex--;
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                        //boolDeleting = true;
                        //leftIndex++;
                    }
                    else if ((s[leftIndex] == s[rightIndex-1]))
                    {
                        boolDeleting = true;
                        rightIndex--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
 
            return true;
        }
    }
}

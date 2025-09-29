using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2843
    {
        ////(2843.) Count Symmetric Integers (EASY)
        public int CountSymmetricIntegers(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)            
            { 
                char[] temp = i.ToString().ToCharArray();
                
                if(temp.Length % 2 == 0)
                {
                    int l = 0;
                    int r = temp.Length-1;
                    int result = 0;
                    while (l < r)
                    {
                        result += (int)temp[l++] - (int)temp[r--];
                    }
                    if (result == 0)
                    {
                        count++;
                    }
                }       
            }
            return count;
        }
    }
}

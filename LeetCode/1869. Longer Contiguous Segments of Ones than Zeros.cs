using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1869
    {
        ////(1869.) Longer Contiguous Segments of Ones than Zeros (EASY)
        public bool CheckZeroOnes(string s)
        {
            int maxContiguousOnes = 0;
            int maxContiguousZeros = 0;
            char lastChar = 'k';
            int currContiguous = 0;

            foreach (char c in s) 
            { 
                if(lastChar == c)
                {
                    currContiguous++;
                    if (c == '0')
                    {
                        maxContiguousZeros = currContiguous > maxContiguousZeros? currContiguous : maxContiguousZeros; 
                    }
                    else
                    {
                        maxContiguousOnes = currContiguous > maxContiguousOnes? currContiguous : maxContiguousOnes;
                    }
                }
                else
                {
                    currContiguous = 1;
                    if (c == '0')
                    {
                        maxContiguousZeros = currContiguous > maxContiguousZeros ? currContiguous : maxContiguousZeros;
                    }
                    else
                    {
                        maxContiguousOnes = currContiguous > maxContiguousOnes ? currContiguous : maxContiguousOnes;
                    }
                }
                lastChar = c;
            }
            
            if(maxContiguousOnes > maxContiguousZeros)
            {
                return true;
            }
            return false;
        }
    }
}

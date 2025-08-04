using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2011
    {
        ////(2011.) Final Value of Variable After Performing Operations (EASY)
        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "++X":
                        result++;
                        break;
                    case "X++":
                        result++;
                        break;
                    case "--X":
                        result--;
                        break;
                    case "X--":
                        result--;
                        break;
                }
            }

            return result;
        }
    }
}

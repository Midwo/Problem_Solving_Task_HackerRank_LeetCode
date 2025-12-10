using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1346
    {
        ////(1346.) Check If N and Its Double Exist (EASY)
        public bool CheckIfExist(int[] arr)
        {
            bool status = false;

            for (int j = 0; j < arr.Length; j++)
            {
                int doubleValue = arr[j]*2;
                for (int i = 0; i < arr.Length; i++)
                {
                    if(i != j & arr[i] == doubleValue)
                    {
                        return true;
                    }
                }
            }

            return status;
        }
    }
}

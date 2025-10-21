using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3668
    {
        ////(3668.) Restore Finishing Order (EASY)
        public int[] RecoverOrder(int[] order, int[] friends)
        {
            int[] resultArray = new int[friends.Length];
            int indexResultArray = 0;
            for (int i = 0; i < order.Length; i++)
            {
                int temp = order[i];
                for (int j = 0; j < friends.Length; j++)
                {
                    if (temp == friends[j])
                    {
                        resultArray[indexResultArray++] = friends[j];
                        break;
                    }
                }
            }

            return resultArray;
        }
    }
}

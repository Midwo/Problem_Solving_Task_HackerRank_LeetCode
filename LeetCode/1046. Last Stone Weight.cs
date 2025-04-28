using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1046
    {
        ////(1046.) Last Stone Weight (EASY)
        public int LastStoneWeight(int[] stones)
        {
            List<int> listWeight = new List<int>();
                
            foreach (var item in stones)
            {
                listWeight.Add(item);
            }

            int length = listWeight.Count;
            listWeight.Sort();

            while (length > 1)
            {
                if (listWeight[length - 1] == listWeight[length - 2])
                {
                    listWeight.RemoveAt(length - 2);
                    listWeight.RemoveAt(length - 2);
                    length -= 2;
                }
                else if (listWeight[length-1] != listWeight[length -2]) 
                {
                    int temp = listWeight[length - 1] - listWeight[length - 2];

                    listWeight.RemoveAt(length - 2);
                    listWeight.RemoveAt(length - 2);
                    listWeight.Add(temp);
                    listWeight.Sort();

                    length -= 1;
                }
            }   
            
            if (listWeight.Count < 1)
            {
                return 0;
            }

            return listWeight[0];
        }

    }
}

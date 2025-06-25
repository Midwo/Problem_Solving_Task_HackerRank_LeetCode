using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2200
    {
        ////(2200.) Find All K-Distant Indices in an Array (EASY)
        public IList<int> FindKDistantIndices(int[] nums, int key, int k)
        {
            List<int> result = new List<int>();
            int length = nums.Length;
            List<int> listFindIndex = new List<int>();

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == key)
                {
                   listFindIndex.Add(i);
                }
            }
            int startIndex = listFindIndex[0] - k;
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            int howManyFind = listFindIndex.Count;
            int indexlist = 0;

            for (int i = startIndex; i < length; i++) 
            {
                if (Math.Abs(listFindIndex[indexlist] - i) <= k)
                {
                    result.Add(i);    
                }
                else
                {
                    if(indexlist < howManyFind-1)
                    {
                        indexlist++;
                        if (Math.Abs(listFindIndex[indexlist] - i) <= k)
                        {
                            i--;
                        }
                        else
                        {
                            i = listFindIndex[indexlist]-2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

            }  

            return result;
        }
    }
}

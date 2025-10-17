using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2363
    {
        ////(2363.) Merge Similar Items (EASY)
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            IList<IList<int>> result = new List<IList<int>>();

            items1 = items1.OrderBy(c => c[0]).ToArray();
            items2 = items2.OrderBy(c => c[0]).ToArray();

            int currValue1 = 0;
            int currValue2 = 0;
            int currWeight1 = 0;
            int currWeight2 = 0;
            int lengthItem1 = items1.Length;
            int lengthItem2 = items2.Length;
            int index1 = 0;
            int index2 = 0;

            while (index1 < lengthItem1 || index2 < lengthItem2)
            {
                if(index1 < lengthItem1)
                {
                    currValue1 = items1[index1][0];
                }
                if (index2 < lengthItem2) 
                { 
                    currValue2 = items2[index2][0];
                }
                if (currValue1 == currValue2)
                {
                    if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                    }
                    if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                    }
                    result.Add(new List<int> { currValue1, (currWeight1 + currWeight2) });
                }
                else if(currValue1 < currValue2)
                {
                    if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                        result.Add(new List<int> { currValue1, (currWeight1) });
                    }
                    else if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                        result.Add(new List<int> { currValue2, (currWeight2) });

                    }
                }
                else
                {
                    if (index2 < lengthItem2)
                    {
                        currWeight2 = items2[index2++][1];
                        result.Add(new List<int> { currValue2, (currWeight2) });

                    }
                    else if (index1 < lengthItem1)
                    {
                        currWeight1 = items1[index1++][1];
                        result.Add(new List<int> { currValue1, (currWeight1) });
                    }
                }
            }
            return result;
        }
    }
}

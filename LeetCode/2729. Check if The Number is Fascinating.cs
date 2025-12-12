using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2729
    {
        ////(2729.) Check if The Number is Fascinating (EASY)
        public bool IsFascinating(int n)
        {
            HashSet<int> numbers = new HashSet<int>();
            int currValue = n * 1;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                int temp = currValue % 10;
                if (temp == 0 || !numbers.Add(temp))
                {
                    return false;
                }
                currValue /= 10;
            }
            if (numbers.Count != 3)
            {
                return false;
            }
            currValue = n * 2;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                int temp = currValue % 10;
                if (temp == 0 || numbers.Contains(temp))
                {
                    return false;
                }
                numbers.Add(temp);
                currValue /= 10;
            }
            if (numbers.Count != 6)
            {
                return false;
                
            }
            currValue = n * 3;
            if (currValue > 987)
            {
                return false;
            }
            while (currValue != 0)
            {
                    int temp = currValue % 10;
                    if (temp == 0 || numbers.Contains(temp))
                    {
                        return false;
                    }
                    numbers.Add(temp);

                    currValue /= 10;
                }
            if (numbers.Count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }

            //bool isFacinating = false;

            //for (int i = 1; i < 7; i++)
            //{
            //    HashSet<int> numbersI = new HashSet<int>();
            //    int currValueI = n * i;
            //    if (currValueI > 987)
            //    {
            //        break;
            //    }
            //    while(currValueI != 0)
            //    {
            //        int temp = currValueI % 10;
            //        if (temp == 0 | !numbersI.Add(temp))
            //        {
            //            break;
            //        }
            //        currValueI /= 10;
            //    }
            //    if (numbersI.Count != 3)
            //    {
            //        continue;
            //    }
            //    for (int j = i+1; j < 6; j++)
            //    {
            //        HashSet<int> numbersJ = new HashSet<int>();
            //        int currValueJ = n * j;
            //        if (currValueJ > 987)
            //        {
            //            break;
            //        }
            //        while (currValueJ != 0)
            //        {
            //            int temp = currValueJ % 10;
            //            if (temp == 0 | numbersI.Contains(temp) | numbersJ.Contains(temp))
            //            {
            //                break;
            //            }
            //            numbersJ.Add(temp);
            //            currValueJ /= 10;
            //        }
            //        if (numbersJ.Count != 3)
            //        {
            //            continue;
            //        }
            //        for (int y = j + 1; y < 5; y++)
            //        {
            //            HashSet<int> numbersY = new HashSet<int>();
            //            int currValueY = n * y;
            //            if (currValueY > 987)
            //            {
            //                break;
            //            }
            //            while (currValueY != 0)
            //            {
            //                int temp = currValueY % 10;
            //                if (temp == 0 | numbersI.Contains(temp) | numbersJ.Contains(temp) | numbersY.Contains(temp))
            //                {
            //                    break;
            //                }
            //                numbersY.Add(temp);

            //                currValueY /= 10;
            //            }
            //            if (numbersY.Count != 3)
            //            {
            //                continue;
            //            }
            //            else
            //            {
            //                return true;
            //            }
            //        }
            //    }


            //}
            //return isFacinating;
        }
    }
}

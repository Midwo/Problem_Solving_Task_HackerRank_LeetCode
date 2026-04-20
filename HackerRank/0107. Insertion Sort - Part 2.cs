using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0107
    {
        ////107. Insertion Sort - Part 2 (EASY)
        public void insertionSort2(int n, List<int> arr)
        {
            ////Solution 1 (New - Better)

            for (int index = 1; index < arr.Count; index++)
            {
                int currValue = arr[index];
                int j = index - 1;

                while(j >= 0 && arr[j] > currValue)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j + 1] = currValue;
                Console.WriteLine(string.Join(' ', arr));
            }

            ////Solution 2 (Old - Poor)

            //bool good = false;

            //do
            //{
            //    for (int x = 1; x < arr.Count; x++)
            //    {
            //        string xstring = string.Empty;

            //        if (arr[x] < arr[x - 1])
            //        {
            //            int whereInsterValue = x - 1;
            //            for (int item1 = 0; item1 < x; item1++)
            //            {
            //                if (arr[item1] > arr[x])
            //                {
            //                    whereInsterValue = item1;
            //                    break;
            //                }
            //            }
            //            int removedRecord = arr[x];
            //            arr.RemoveAt(x);
            //            arr.Insert(whereInsterValue, removedRecord);
            //        }
            //        foreach (var item in arr)
            //        {
            //            xstring += " " + item;
            //        }
            //        Console.WriteLine(xstring.Trim());
            //    }

            //    bool firstValueprevious = true;
            //    int previousValue = int.MinValue;
            //    foreach (int i in arr)
            //    {
            //        if (firstValueprevious)
            //        {
            //            firstValueprevious = false;
            //            previousValue = i;
            //        }
            //        else
            //        {
            //            if (previousValue < i)
            //            {
            //                previousValue = i;
            //            }
            //            else
            //            {
            //                good = true;
            //                previousValue = i;
            //            }
            //        }

            //    }

            //} while (good);
        }
    }
}

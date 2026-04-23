using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0122
    {
        ////122. Beautiful Triplets (EASY)
        public int beautifulTriplets(int d, List<int> arr)
        {
            ////Solution 1(New - Better)
            int lenght = arr.Count;
            int countBeautifulTriplets = 0;

            for (int indexFirstValue = 0; indexFirstValue < lenght - 2; indexFirstValue++)
            {
                int firstseachrValue = arr[indexFirstValue] + d;

                for (int indexSecondValue = indexFirstValue + 1; indexSecondValue < lenght - 1; indexSecondValue++)
                {
                    if (arr[indexSecondValue] == firstseachrValue)
                    {
                        int secondSearchValue = firstseachrValue + d;
                        for (int indexLastValue = indexSecondValue + 1; indexLastValue < lenght; indexLastValue++)
                        {
                            if (secondSearchValue == arr[indexLastValue])
                                countBeautifulTriplets++;
                        }
                    }
                }
            }
            return countBeautifulTriplets;

            //Solution 2 (Old - Poor)
            //int howMany = 0;
            //for (int i = 0; i <= arr.Count; i++)
            //{
            //    for (int j = i + 1; j < arr.Count; j++)
            //    {
            //        if (arr[j] - arr[i] == d)
            //        {
            //            for (int x = j + 1; x < arr.Count; x++)
            //            {
            //                if (arr[x] - arr[j] == d)
            //                {
            //                    howMany++;
            //                    break;
            //                }
            //            }
            //            break;
            //        }
            //    }
            //}
            //return howMany;
        }
    }
}

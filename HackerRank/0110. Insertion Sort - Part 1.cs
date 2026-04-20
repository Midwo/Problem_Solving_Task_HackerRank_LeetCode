using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0110
    {
        ////110. Insertion Sort - Part 1 (EASY)
        public void insertionSort1(int n, List<int> arr)
        {
            var last = arr[n - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                if (i == 0 || last > arr[i - 1])
                {
                    arr[i] = last;
                    Console.WriteLine(string.Join(" ", arr));
                    break;
                }
                else
                {
                    arr[i] = arr[i - 1];
                    Console.WriteLine(string.Join(" ", arr));
                }
            }
        }
    }
}

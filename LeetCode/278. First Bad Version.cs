using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_278
    {
        ////(278.) First Bad Version
        public int FirstBadVersion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int end = n;
            int begin = 1;
            while (begin < end)
            {
                int mid = begin + (end - begin) / 2;
                if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else if (IsBadVersion(mid) == false && IsBadVersion(mid + 1) == true)
                {
                    return mid + 1;
                }
                else
                {
                    begin = mid + 1;
                }
            }
            if (begin != n && IsBadVersion(begin)) return begin;
            return -1;
        }
        private bool IsBadVersion(int n)
        {
            bool result = false;
            Dictionary<int, bool> dictionaryBadVersion = new Dictionary<int, bool>()
            {
                {1, true}, {2, true}, {3, true}, {4, true}, {5, true}, {6, true}, {7, true}, {8, true}, {9, true}, {10, true}, {11, true}
            };
            if (dictionaryBadVersion.ContainsKey(n))
            {
                return dictionaryBadVersion[n];
            }
            return true;            
        }
    }
}

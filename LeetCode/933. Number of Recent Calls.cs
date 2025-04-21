using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_933
    {
        ////(933.) Number of Recent Calls (EASY)
        public class RecentCounter
        {
            private List<int> _list;
            private int _startIndex;
            public RecentCounter()
            {
                _list = new List<int>();
                _startIndex = 0;
            }

            public int Ping(int t)
            {
                _list.Add(t);

                while (_list[_startIndex] < t - 3000)
                {
                    _startIndex++;
                }
                //Console.WriteLine(_list.Count - _startIndex);
                return _list.Count - _startIndex;
            }
        }
    }
}

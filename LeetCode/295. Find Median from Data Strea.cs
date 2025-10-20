using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_295
    {
        ////(295.) Find Median from Data Strea (HARD)
        public class MedianFinder
        {
            private PriorityQueue<int, int> _smallPriorityQueue;
            private PriorityQueue<int, int> _bigPriorityQueue;
            public MedianFinder()
            {
                _bigPriorityQueue = new PriorityQueue<int, int>();
                _smallPriorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
            }

            public void AddNum(int num)
            {
                if (_bigPriorityQueue.Count != 0 && num > _bigPriorityQueue.Peek())
                {
                    _bigPriorityQueue.Enqueue(num, num);
                }
                else
                {
                    _smallPriorityQueue.Enqueue(num, num);
                }

                if (_smallPriorityQueue.Count > _bigPriorityQueue.Count + 1)
                {
                    int tempValue = _smallPriorityQueue.Dequeue();
                    _bigPriorityQueue.Enqueue(tempValue, tempValue);
                }
                else if (_bigPriorityQueue.Count > _smallPriorityQueue.Count + 1) 
                {
                    int tempValue = _bigPriorityQueue.Dequeue();
                    _smallPriorityQueue.Enqueue(tempValue, tempValue);
                }

            }

            public double FindMedian()
            {
                if(_bigPriorityQueue.Count > _smallPriorityQueue.Count)
                {
                    return _bigPriorityQueue.Peek();
                }
                else if (_smallPriorityQueue.Count > _bigPriorityQueue.Count)
                {
                    return _smallPriorityQueue.Peek();
                }

                return ((_smallPriorityQueue.Peek() + _bigPriorityQueue.Peek()) / 2.0);
            }
        }

    }
}

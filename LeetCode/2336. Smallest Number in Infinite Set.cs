using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2336
    {
        ////(2336.) Smallest Number in Infinite Set (MEDIUM)
        public class SmallestInfiniteSet
        {
            private int _currInfiniteValue;
            private PriorityQueue<int, int> _addedValuesPriorityQueue;
            private HashSet<int> _currValuesInPriorityQueue;  
            public SmallestInfiniteSet()
            {
                _currInfiniteValue = 1;
                _addedValuesPriorityQueue = new PriorityQueue<int, int>();
                _currValuesInPriorityQueue = new HashSet<int>();
            }

            public int PopSmallest()
            {
                if (_currValuesInPriorityQueue.Count == 0)
                {
                    return _currInfiniteValue++;
                }
                else
                {
                    if (_currInfiniteValue < _addedValuesPriorityQueue.Peek())
                    {
                        return _currInfiniteValue++;
                    }
                    else if (_currInfiniteValue > _addedValuesPriorityQueue.Peek())
                    {
                        int returnValue = _addedValuesPriorityQueue.Dequeue();
                        _currValuesInPriorityQueue.Remove(returnValue);
                        return returnValue;
                    }
                    else
                    {
                        int returnValue = _addedValuesPriorityQueue.Dequeue();
                        _currValuesInPriorityQueue.Remove(returnValue);
                        return _currInfiniteValue++;
                    }
                }
            }

            public void AddBack(int num)
            {
                if(_currInfiniteValue > num && !_currValuesInPriorityQueue.Contains(num))
                {
                    _currValuesInPriorityQueue.Add(num);
                    _addedValuesPriorityQueue.Enqueue(num, num);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1381
    {
        ////(1381.) Design a Stack With Increment Operation (MEDIUM)
        public class CustomStack
        {
            private int[] _customStackTable;
            private int _maxSize;
            private int _currSize;
            private int _lastIndex;
            public CustomStack(int maxSize)
            {
                _customStackTable = new int[maxSize];
                _maxSize = maxSize;
                _currSize = 0;
                _lastIndex = -1;
            }

            public void Push(int x)
            {
                if (_currSize < _maxSize) 
                {
                    _customStackTable[++_lastIndex] = x;
                    _currSize++;
                }
            }

            public int Pop()
            {
                if(_currSize > 0)
                {
                    _currSize--;
                    return _customStackTable[_lastIndex--];
                }
                else
                {
                    return -1;
                }
            }

            public void Increment(int k, int val)
            {
                int lenght = Math.Min(k, _currSize);

                for (int i = 0; i < lenght; i++) 
                {
                    _customStackTable[i] += val;
                }
            }
        }
    }
}

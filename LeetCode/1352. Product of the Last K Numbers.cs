using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1352
    {
        ////(1352.) Product of the Last K Numbers (MEDIUM)
        public class ProductOfNumbers
        {
            private List<int> _prefixValues = new List<int>();
            int _lastPrefixValue;
            public ProductOfNumbers()
            {
                _prefixValues = new List<int>();
                _lastPrefixValue = 1;
            }

            public void Add(int num)
            {
                if(num == 0)
                {
                    _prefixValues.Clear();
                    _lastPrefixValue = 1;
                }
                else
                {
                    _lastPrefixValue *= num;
                    _prefixValues.Add(_lastPrefixValue);
                }
            }

            public int GetProduct(int k)
            {
                int countElements = _prefixValues.Count;
                
                if (countElements < k)
                {
                    return 0;
                }
                else
                {
                    if(countElements == k)
                    {
                        return _prefixValues[countElements - 1];
                    }
                    return _prefixValues[countElements -1] / _prefixValues[countElements - 1 - k];
                }
            }
        }
    }
}

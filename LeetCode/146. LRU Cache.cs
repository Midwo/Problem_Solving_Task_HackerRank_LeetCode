using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_146
    {
        ////(146.) LRU Cache (MEDIUM)
        public class LRUCache
        {
            private List<int> _cacheKey;
            private List<int> _cacheValue;

            private int _maxSize;
            public LRUCache(int capacity)
            {
                _cacheKey = new List<int>();
                _cacheValue = new List<int>();
                _maxSize = capacity;
            }

            public int Get(int key)
            {
                if (_cacheKey.Contains(key))
                {
                    int temp = _cacheKey.IndexOf(key);
                    int tempValue = _cacheValue[temp];
                    _cacheKey.RemoveAt(temp); 
                    _cacheValue.RemoveAt(temp);
                    //_lastKeyUsed = key;
                    _cacheKey.Add(key);
                    _cacheValue.Add(tempValue);
                    return tempValue;
                }
                else
                {
                    return -1;
                }
            }

            public void Put(int key, int value)
            {
                if(_maxSize > 0)
                {
                    if (_cacheKey.Contains(key))
                    {
                        int temp = _cacheKey.IndexOf(key);
                        int tempValue = _cacheValue[temp];
                        _cacheKey.RemoveAt(temp);
                        _cacheValue.RemoveAt(temp);
                        //_lastKeyUsed = key;
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                    else
                    {
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                        _maxSize--;
                    }
                }
                else
                {
                    if (_cacheKey.Contains(key))
                    {
                        int temp = _cacheKey.IndexOf(key);
                        int tempValue = _cacheValue[temp];
                        _cacheKey.RemoveAt(temp);
                        _cacheValue.RemoveAt(temp);
                        //_lastKeyUsed = key;
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                    else
                    {
                        _cacheKey.RemoveAt(0);
                        _cacheValue.RemoveAt(0);
                        _cacheKey.Add(key);
                        _cacheValue.Add(value);
                    }
                }
            }
        }
    }
}

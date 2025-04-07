using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_706
    {
        ////(706.) Design HashMap (EASY)
        public class MyHashMap
        {
            private Dictionary<int, int> _dictionaryKeyValue;
            public MyHashMap()
            {
                _dictionaryKeyValue = new Dictionary<int, int>();
            }

            public void Put(int key, int value)
            {
                if (_dictionaryKeyValue.ContainsKey(key))
                {
                    _dictionaryKeyValue[key] = value;
                }
                else
                {
                    _dictionaryKeyValue.Add(key, value);
                }
            }

            public int Get(int key)
            {
                if (_dictionaryKeyValue.ContainsKey(key))
                { 
                    return _dictionaryKeyValue[key];
                }
                else
                {
                    return -1;
                }
            }

            public void Remove(int key)
            {
                if (_dictionaryKeyValue.ContainsKey(key)) 
                {
                    _dictionaryKeyValue.Remove(key);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_705
    {
        ////(705.) Design HashSet (EASY)
        public class MyHashSet
        {
            private HashSet<int> _hashset;
            public MyHashSet()
            {
                _hashset = new HashSet<int>();
            }

            public void Add(int key)
            {
                _hashset.Add(key);
            }

            public void Remove(int key)
            {
                _hashset.Remove(key);
            }

            public bool Contains(int key)
            {
                if (_hashset.Contains(key))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

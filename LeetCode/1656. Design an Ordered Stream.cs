using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1656
    {
        ////(1656.) Design an Ordered Stream (EASY)
        public class OrderedStream
        {
            private string[] _strings;
            private int _index;
            public OrderedStream(int n)
            {
                _index = 0;
                _strings = new string[n];
            }

            public IList<string> Insert(int idKey, string value)
            {
                if(_index != idKey - 1)
                {
                    _strings[idKey-1] = value;
                    return [];
                }
                else
                {
                    int howLong = 0;
                    _strings[idKey - 1] = value;
                    for (int i = idKey; i < _strings.Length; i++)
                    {
                        if (_strings[i] == null)
                        {
                            break;
                        }
                        else
                        {
                            howLong++;
                        }
                    }
                    _index += howLong+1;
                    return _strings[(_index- howLong -1)..(_index)];
                }
            }
        }
    }
}

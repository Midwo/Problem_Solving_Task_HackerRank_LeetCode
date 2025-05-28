using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_380
    {
        ////(380.) Insert Delete GetRandom O(1) (MEDIUM)
        public class RandomizedSet
        {
            private Dictionary<int, int> dictionaryValue;
            private List<int> listValue;
            private Random rnd;

            public RandomizedSet()
            {
                listValue = new List<int>();
                dictionaryValue = new Dictionary<int, int>();
                rnd = new Random();
            }

            public bool Insert(int val)
            {
                if (dictionaryValue.ContainsKey(val))
                {
                    return false;
                }

                dictionaryValue[val] = dictionaryValue.Count;
                listValue.Add(val);
                return true;
            }

            public bool Remove(int val)
            {
                if (!dictionaryValue.ContainsKey(val)) return false;

                int indexListValue = dictionaryValue[val];
                int lastElementValue = listValue[listValue.Count - 1];
                listValue[indexListValue] = lastElementValue;
                dictionaryValue[lastElementValue] = indexListValue;

                listValue.RemoveAt(listValue.Count - 1);
                dictionaryValue.Remove(val);

                return true;
            }

            public int GetRandom()
            {
                return listValue[rnd.Next(listValue.Count)];
            }
        }
    }
}

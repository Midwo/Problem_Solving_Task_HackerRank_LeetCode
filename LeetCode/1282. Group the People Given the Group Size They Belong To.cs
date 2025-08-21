using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1282
    {
        ////(1282.) Group the People Given the Group Size They Belong To (MEDIUM)
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> listGroup = new List<IList<int>>();

            Dictionary<int, int> dictionaryValueKeyList = new Dictionary<int, int>();
            
            int indexListGroup = 0;

            for (int i = 0; i < groupSizes.Length; i++) 
            {
                if (dictionaryValueKeyList.ContainsKey(groupSizes[i]))
                {
                    listGroup[dictionaryValueKeyList[groupSizes[i]]].Add(i);
                }
                else
                {
                    dictionaryValueKeyList.Add(groupSizes[i], indexListGroup);
                    IList<int> tempNewGroup = new List<int>() { i };
                    listGroup.Add(tempNewGroup);
                    indexListGroup++;
                }
            }

            IList<IList<int>> resultlistGroup = new List<IList<int>>();
            
            foreach (var item in dictionaryValueKeyList)
            {
                int count = 0;
                int indexValueInList = 0;
                IList<int> tempList = new List<int>();
                for (int i = 0; i < listGroup[item.Value].Count; i++)
                {
                    if (++count == item.Key)
                    {
                        tempList.Add(listGroup[item.Value][indexValueInList]);
                        resultlistGroup.Add(tempList);
                        tempList = new List<int>();
                        indexValueInList++;
                        count = 0;
                    }
                    else
                    {
                        tempList.Add(listGroup[item.Value][indexValueInList]);
                        indexValueInList++;
                    }
                }
            } 

            return resultlistGroup;
        }
    }
}

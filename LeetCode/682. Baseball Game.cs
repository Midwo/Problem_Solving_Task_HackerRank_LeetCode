using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_682
    {
        ////(682.) Baseball Game (EASY)
        public int CalPoints(string[] operations)
        {
            List<int> listRecords = new List<int>();
            foreach (string item in operations) 
            {
                switch (item)
                {
                    case "D":
                        listRecords.Add(listRecords[listRecords.Count-1]*2);
                        break;

                    case "C":
                        listRecords.RemoveAt(listRecords.Count-1);
                        break;
                    case "+":
                        listRecords.Add(listRecords[listRecords.Count - 1] + listRecords[listRecords.Count - 2]);
                        break;
                    default:
                        listRecords.Add(Int32.Parse(item));
                        break;
                }
            }
            int result = 0;
            foreach (int record in listRecords) 
            {
                result += record;
            }
            return result;
            //// for a slow solution
            // result listRecords.SUM()
        }
    }
}

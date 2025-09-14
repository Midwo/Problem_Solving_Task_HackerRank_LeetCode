using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2194
    {
        ////(2194.) Cells in a Range on an Excel Sheet (EASY)
        public IList<string> CellsInRange(string s)
        {
            IList<string> list = new List<string>();
            string[] divideList = s.Split(':');
            char[] chars = new char[2];
            chars[0] = divideList[0][0];
            chars[1] = divideList[1][0];
            int rowsStart = int.Parse(divideList[0][1..(divideList[0].Length)]); 
            int rowStop = int.Parse(divideList[1][1..(divideList[0].Length)]);

            while (chars[0] <= chars[1])
            {
                for (int i = rowsStart; i <= rowStop; i++)
                {
                    list.Add(String.Concat(chars[0],i));
                }
                chars[0]++;
            }

            return list;
        }
    }
}

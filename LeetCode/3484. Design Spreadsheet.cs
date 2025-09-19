using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3484
    {
        ////(3484.) Design Spreadsheet (MEDIUM)
        public class Spreadsheet
        {
            //// 28ms, Beats: 80.00%
            
            private int[][] _tableExcel;
            public Spreadsheet(int rows)
            {
                _tableExcel = new int [26][];
                for (int i = 0; i < 26; i++)
                {
                    _tableExcel[i] = new int[rows];
                }
            }

            public void SetCell(string cell, int value)
            {
                _tableExcel[(cell[0] - 'A')][int.Parse(cell[1..cell.Length])-1] = value;
            }

            public void ResetCell(string cell)
            {
                _tableExcel[(cell[0] - 'A')][int.Parse(cell[1..cell.Length]) - 1] = 0;
            }

            public int GetValue(string formula)
            {
                string[] tempString = formula.Split('+');
                int value1 = 0;
                if (tempString[0][1] >= 'A' && tempString[0][1] <= 'Z')
                {
                    value1 = _tableExcel[tempString[0][1] - 'A'][int.Parse(tempString[0][2..tempString[0].Length])-1];
                }
                else
                {
                    value1 = int.Parse(tempString[0][1..tempString[0].Length]);
                }
                if (tempString[1][0] >= 'A' && tempString[1][0] <= 'Z')
                {
                    return value1 + (_tableExcel[tempString[1][0] - 'A'][int.Parse(tempString[1][1..tempString[1].Length]) - 1]);
                }
                else
                {
                    return value1 + int.Parse(tempString[1]);
                }
            }
        }

    }
}

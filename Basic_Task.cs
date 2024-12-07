using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Basic_Task
    {
        public string Happy_ladybugs(string b)
        {
            //b = "RBY_YBR";
            Dictionary<int, int> dictionaryString = new Dictionary<int, int>();
            int howManyChar95 = 0;
            int howManyOtherChar = 0;
            int howLongString = b.Length;
            char firstChar = b[0];
            char nextChar = b[0];
            int twoWrongValues = 0;

            foreach (char s in b)
            {
                if (s != 95)
                {
                    howManyOtherChar++;
                    if (dictionaryString.ContainsKey(s))
                    {
                        dictionaryString[s]++;
                    }
                    else
                    {
                        dictionaryString.Add(s, 1);
                    }
                }
                else
                {
                    howManyChar95++;
                }
            }

            if (dictionaryString.ContainsValue(1))
            {
                return "NO";
            }
            else
            {
                if (howManyChar95 > 0)
                {
                    return "YES";
                }
                else
                {
                    for (int i = 1; i < b.Length; i++)
                    {
                        nextChar = b[i];
                        if (firstChar == nextChar)
                        {
                            firstChar = b[i];
                            twoWrongValues = 0;
                        }
                        else
                        {
                            firstChar = b[i];
                            twoWrongValues++;
                            if (twoWrongValues >= 2)
                            {
                                return "NO";
                            }
                        }
                    }
                    if (twoWrongValues < 2)
                    {
                        return "YES";
                    }
                    else
                    {
                        return "NO";
                    }
                }
            }
        }

        public List<string> Cavity_Map(List<string> grid)
        {
            //grid = ["1112", "1912", "1892", "1234"];
            int lenghtStringInGrid = grid[0].Length;
            int countGridMinusOne = grid.Count - 1;
            List<string> newGrid = new List<string>();
            newGrid = grid.ToList();

            for (int i = 1; i < lenghtStringInGrid - 1; i++)
            {
                for (int x = 1; x < countGridMinusOne; x++)
                {
                    int actualRecordValue = Int32.Parse(grid[x][i].ToString());
                    if (actualRecordValue > Int32.Parse(grid[x - 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x + 1][i].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i - 1].ToString()) &&
                    actualRecordValue > Int32.Parse(grid[x][i + 1].ToString()))
                    {
                        newGrid[x] = newGrid[x].Substring(0, i) + "X" + newGrid[x].Substring(i + 1);
                    }
                }
            }
            return newGrid;
        }
    
        public string kaprekarNumbers(int p, int q)
        {
            //p = 1;
            //q = 100;
            string outPrint = string.Empty;

            for (int i = p; i <= q; i++)
            {
                var square = Math.Pow(i, 2);
                var howLongSquareNumber = square.ToString().Length;
                var howLongLoopNumber = i.ToString().Length;
                int leftValue = 0;
                int rightValue = 0;

                if (howLongSquareNumber > 1)
                {
                    int digitsForLeft = howLongSquareNumber - howLongLoopNumber;
                    leftValue = Convert.ToInt32(square.ToString().Substring(0, digitsForLeft));
                    rightValue = Convert.ToInt32(square.ToString().Substring(digitsForLeft));
                }
                else
                {
                    rightValue = (int)square;
                }
                if (leftValue + rightValue == i)
                {
                    outPrint += i + " ";
                }
            }
            return outPrint.Length > 0 ? outPrint.TrimEnd() : "INVALID RANGE";
        }
    }
}

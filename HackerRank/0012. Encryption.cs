using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0012
    {
        public string encryption(string s)
        {
            int howLong = s.Length;
            double doubleSqrtValue = Math.Sqrt(howLong);
            int ceilingSqrtValue = (int)Math.Ceiling(doubleSqrtValue);
            int floorSqrtValue = (int)Math.Floor(doubleSqrtValue);
            if (ceilingSqrtValue * floorSqrtValue < howLong)
            {
                floorSqrtValue = ceilingSqrtValue;
            }
            List<string> listEncryption = new List<string>();
            for (int i = 0; i < floorSqrtValue; i++)
            {
                if (i == floorSqrtValue - 1)
                {
                    listEncryption.Add(s.Substring(i * ceilingSqrtValue));
                }
                else
                {
                    listEncryption.Add(s.Substring(i * ceilingSqrtValue, ceilingSqrtValue));
                }
            }
            int howManyLenghtLastRow = listEncryption[floorSqrtValue - 1].Length;
            string newOutput = string.Empty;
            for (int i = 0; i < ceilingSqrtValue; i++)
            {
                for (int x = 0; x < floorSqrtValue; x++)
                {
                    if (i < howManyLenghtLastRow)
                    {
                        newOutput += listEncryption[x][i];
                    }
                    else if (x < floorSqrtValue - 1)
                    {
                        newOutput += listEncryption[x][i];
                    }
                }
                newOutput += " ";
            }
            return newOutput.Trim();
        }

    }
}

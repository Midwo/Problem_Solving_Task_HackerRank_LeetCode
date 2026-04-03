using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0013
    {
        public int alternate(string s)
        {
            int lenghtString = s.Length;
            List<string> allCharsFromString = new List<string>();
            List<string> listStringFromChar = new List<string>();
            int howLongMax = 0;
            foreach (char item in s)
            {
                if (!allCharsFromString.Contains(item.ToString()))
                {
                    allCharsFromString.Add(item.ToString());
                }
            }
            allCharsFromString.Sort();
            for (int i = 0; i < allCharsFromString.Count; i++)
            {
                for (int j = i + 1; j < allCharsFromString.Count; j++)
                {
                    listStringFromChar.Add(allCharsFromString[i].ToString() + allCharsFromString[j].ToString());
                }
            }
            foreach (var item in listStringFromChar)
            {
                string x = string.Empty;
                foreach (var charS in s)
                {
                    if (charS == item[0] || charS == item[1])
                    {
                        x += charS;
                    }
                }
                char lastChar = x[0];
                for (int k = 1; k < x.Length; k++)
                {
                    if (lastChar == x[k])
                    {
                        x = "";
                        break;
                    }
                    else
                    {
                        lastChar = x[k];
                    }
                }
                if (x.Length > 0 && x.Length > howLongMax)
                {
                    howLongMax = x.Length;
                }
            }
            return howLongMax;
        }

    }
}

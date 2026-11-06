using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1496
    {
        ////(1496.) Path Crossing (EASY)
        public bool IsPathCrossing(string path)
        {
            HashSet<string> uniqueLocation = new HashSet<string>() {"0-0"};
            int yPosition = 0;
            int xPosition = 0;

            foreach (char direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        yPosition++;
                        break;
                    case 'S':
                        yPosition--; 
                        break;
                    case 'E':
                        xPosition++; 
                        break;
                    case 'W':
                        xPosition--;
                        break;
                }

                if (!uniqueLocation.Add(yPosition + "-" + xPosition))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

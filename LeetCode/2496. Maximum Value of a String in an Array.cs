using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2496
    {
        ////(2496.) Maximum Value of a String in an Array (EASY)
        public int MaximumValue(string[] strs)
        {
            int maximumValue = 0;

            for (int indexStrs = 0; indexStrs < strs.Length; indexStrs++)
            {
                bool onlyNumbers = true;
                int currValue = 0;

                for (int indexStr = 0; indexStr < strs[indexStrs].Length; indexStr++)
                {
                    if (strs[indexStrs][indexStr] >= '0' && strs[indexStrs][indexStr] <= '9')
                    {
                        currValue *= 10; 
                        currValue += strs[indexStrs][indexStr]-'0';
                    }
                    else
                    {
                        onlyNumbers = false;
                        break;
                    }
                }

                if (onlyNumbers)
                {
                    maximumValue = Math.Max(maximumValue, currValue);
                }
                else
                {
                    maximumValue = Math.Max(maximumValue, strs[indexStrs].Length);
                }
            }

            return maximumValue;
        }
    }
}

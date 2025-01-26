using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_228
    {
        ////(228.) Summary Ranges (EASY)
        public IList<string> SummaryRanges(int[] nums)
        {
            IList<string> resultList = new List<string>();
            int numsLenght = nums.Length;
            bool firstValue = true;
            int startValue = 0;
            int endValue = 0;
            for (int i = 0; i < numsLenght; i++)
            {
                if (i == numsLenght - 1)
                {
                    resultList.Add("" + nums[i] + "");
                    break;
                }
                if (nums[i] + 1 == nums[i + 1])
                {
                    if (firstValue == true)
                    {
                        firstValue = false;
                        startValue = nums[i];
                    }
                    endValue = nums[i + 1];
                    if (i == numsLenght - 2)
                    {
                        resultList.Add("" + startValue + "->" + endValue + "");
                        break;
                    }
                }
                else
                {
                    if (firstValue == false)
                    {
                        firstValue = true;
                        resultList.Add("" + startValue + "->" + endValue + "");
                        if (i == numsLenght - 1)
                        {
                            resultList.Add("" + startValue + "->" + endValue + "");
                            break;
                        }
                    }
                    else
                    {
                        resultList.Add("" + nums[i] + "");
                    }
                }
            }
            return resultList;
        }
    }
}

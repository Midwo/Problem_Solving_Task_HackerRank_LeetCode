using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2138
    {
        ////(2138.) Divide a String Into Groups of Size k (EASY)
        public string[] DivideString(string s, int k, char fill)
        {
            ////Option 1 with string[]. Beats: 100%, runtime: 0 ms.

            int length = s.Length;
            string[] result = new string[(s.Length + k - 1) / k];
            int indexResult = 0;
            int count = 0;
            char[] currCharsWord = new char[k];

            for (int i = 0; i < length; i++)
            {
                if (count == k) 
                {
                    count = 0;
                    result[indexResult] = new string(currCharsWord);
                    indexResult++;
                }
                currCharsWord[count] = s[i];
                count++;
            }

            if (count == 0)
            {
                return result;
            }
            else if (count == k)
            {
                result[indexResult] = new string(currCharsWord);
                return result;
            }
            else
            {
                for (int j = count; j < k; j++) 
                {
                    currCharsWord[j] = fill;
                }
                result[indexResult] = new string(currCharsWord);
                return result;
            }       

            ////Option 2 with List<string>. Beats: 66,67%, runtime: 1 ms. 
            //List<string> resultList = new List<string>();
            //int length = s.Length;
            //string currString = string.Empty;

            //for (int i = 0, j = 0; i < length; i++, j++)
            //{
            //    if(j == k)
            //    {
            //        resultList.Add(currString);
            //        currString = string.Empty;
            //        j = 0;
            //    }

            //    currString += s[i];
                       
            //}
            //if (currString.Length == 0)
            //{
            //    return resultList.ToArray();
            //}
            //else if (currString.Length == k)
            //{
            //    resultList.Add(currString);
            //    return resultList.ToArray();
            //}
            //else
            //{
            //    while(currString.Length < k)
            //    {
            //        currString += fill;
            //    }
            //    resultList.Add(currString);
            //    return resultList.ToArray();
            //}
        }
    }
}

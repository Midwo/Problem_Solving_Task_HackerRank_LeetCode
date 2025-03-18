using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_17
    {
        ////17. Letter Combinations of a Phone Number
        
        //// DFS
        private List<string> result = new List<string>();
        private string buttonNumbers;
        private string[] lettersFromButton = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        private StringBuilder stringBuilderForResult = new StringBuilder();
        public IList<string> LetterCombinations(string digits)
        {
            if(digits.Length == 0)
            {
                return result;
            }
            buttonNumbers = digits;

            GenerateResultDFS(0);

            return result;
        }

        public void GenerateResultDFS(int index) 
        {
            if (index >= buttonNumbers.Length)
            {
                result.Add(stringBuilderForResult.ToString());
                return;
            }
            string tempCurrLettersFromButton = lettersFromButton[buttonNumbers[index] -'2'];

            foreach (char currChar in tempCurrLettersFromButton)
            {
                stringBuilderForResult.Append(currChar);
                GenerateResultDFS(index + 1);
                stringBuilderForResult.Remove(stringBuilderForResult.Length - 1, 1);
            }
        }

        ////// Traversal and other options 
        //public IList<string> LetterCombinations(string digits)
        //{
        ////// Traversal 
        //List<string> result = new List<string>();
        //if (digits.Length == 0)
        //{
        //    return result;
        //}

        //result.Add("");
        //string[] lettersFromButton = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        //foreach (char i in digits)
        //{
        //    string currLettersFromButtonChars = lettersFromButton[i - '2'];
        //    var tempList = new List<string>();
        //    foreach (string a in result)
        //    {
        //        foreach (char b in currLettersFromButtonChars)
        //        {
        //            tempList.Add(a + b);
        //        }
        //    }
        //    result = tempList;
        //}
        //return result;



        ////correct operation and solution of the task but non-responsive version - depending on the length of the input.

        //IList<string> result = new List<string>();

        //Dictionary<char, string> dictionaryNumber = new Dictionary<char, string>()
        //{ 
        //    {'2', "abc"}, {'3', "def"}, {'4', "ghi" }, {'5', "jkl"}, {'6', "mno"}, 
        //    {'7', "pqrs"}, {'8', "tuv"}, {'9',"wxyz"} 
        //};

        //int lengthDigits = digits.Length;
        //int startIndex = 0;
        //if (lengthDigits == 0) return result;
        //for (int i = 0; i < dictionaryNumber[digits[startIndex]].Length; i++)
        //{
        //    if (lengthDigits - 1 == 0)
        //    {
        //        result.Add(dictionaryNumber[digits[startIndex]][i].ToString());
        //    }
        //    else
        //    {
        //        for (int j = 0; j < dictionaryNumber[digits[startIndex + 1]].Length; j++)
        //        {
        //            if (lengthDigits - 2 == 0)
        //            {
        //                result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j]);
        //            }
        //            else
        //            {
        //                for (int k = 0; k < dictionaryNumber[digits[startIndex + 2]].Length; k++)
        //                {
        //                    if (lengthDigits - 3 == 0)
        //                    {
        //                        result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j] + dictionaryNumber[digits[startIndex + 2]][k]);
        //                    }
        //                    else
        //                    {
        //                        for (int l = 0; l < dictionaryNumber[digits[startIndex + 3]].Length; l++)
        //                        {
        //                            result.Add(dictionaryNumber[digits[startIndex]][i].ToString() + dictionaryNumber[digits[startIndex + 1]][j] + dictionaryNumber[digits[startIndex + 2]][k] + dictionaryNumber[digits[startIndex + 3]][l]);
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //return result;
        //}
    }
}

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_386
    {
        ////(386.) Lexicographical Numbers (MEDIUM)
        public IList<int> LexicalOrder(int n)
        {
            List<int> lexicalOrderList = new List<int>();

            int currValue = 1;

            for (int i = 0; i < n; i++)
            {
                lexicalOrderList.Add(currValue);

                if(currValue * 10 <= n)
                {
                    currValue *= 10;
                }
                else
                {
                    while(currValue % 10 == 9 || currValue >= n)
                    {
                        currValue /= 10;
                    }
                    currValue++;
                }
            }

            return lexicalOrderList;


            ////Solution 2

            //List<int> lexicalOrderList = new List<int>();

            //for (int firstValue = 1; firstValue < 10; firstValue++)
            //{
            //    if(firstValue <= n)
            //    {
            //        lexicalOrderList.Add(firstValue);
            //        GenerateNextValuesLexicalOrder(firstValue);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //void GenerateNextValuesLexicalOrder(int value)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        int currtemp = value * 10 + i;
            //        if(currtemp <= n)
            //        {
            //            lexicalOrderList.Add(currtemp);
            //            GenerateNextValuesLexicalOrder(currtemp);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}

            //return lexicalOrderList;
        }
    }
}

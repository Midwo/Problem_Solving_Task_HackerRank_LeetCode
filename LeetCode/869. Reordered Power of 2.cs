using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_869
    {
        ////(869.) Reordered Power of 2 (MEDIUM)
        public bool ReorderedPowerOf2(int n)
        {
            bool result = false;

            List<string> listPow2OrderByDescValue = new List<string>()
            {
               "1","2","4","8","61","32","64","821","652","521","4210","8420","9640","9821",
                "86431","87632","66553","732110","644221","885422","8765410","9752210","9444310",
                "8888630","77766211","55443332","88766410","877432211","866554432","987653210","8774432110"
            };

            char[] temp = n.ToString().ToCharArray();
            temp = temp.OrderByDescending(x => x).ToArray();

            if (listPow2OrderByDescValue.Contains(new string(temp)))
            {
                return true;
            }

            //bool result = false;
            //int tenPowNine = (int)Math.Pow(10, 9);

            //List<string> listPow2 = new List<string>();
            //int lastValue = 1;
            //listPow2.Add(lastValue.ToString());

            //while(lastValue <= tenPowNine)
            //{
            //    lastValue *= 2;
            //    listPow2.Add(lastValue.ToString());
            //}

            //for (int i = 1; i < listPow2.Count; i++)
            //{
            //    char[] temp = listPow2[i].ToString().ToCharArray();
            //    temp = temp.OrderByDescending(x => x).ToArray();
            //    //Console.WriteLine(string.Join(',', temp));
            //    listPow2[i] = new string(temp);
            //}


            //Console.WriteLine(string.Join(',', listPow2));

            return result;
        }
    }
}

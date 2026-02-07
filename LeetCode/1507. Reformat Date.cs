using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1507
    {
        ////(1507.) Reformat Date (EASY)
        public string ReformatDate(string date)
        {
            string[] splitString = date.Split(' ');

            //string[][] monthTable = [["Jan","01"], ["Feb","02"], ["Mar", "03"], ["Apr", "04"], ["May", "05"], ["Jun","06"], ["Jul","07"], ["Aug","08"], ["Sep","09"], ["Oct","10"], ["Nov","11"], ["Dec","12"]];
            Dictionary<string, string> dictMonth = new Dictionary<string, string>
            {
                ["Jan"] = "01",
                ["Feb"] = "02",
                ["Mar"] = "03",
                ["Apr"] = "04",
                ["May"] = "05",
                ["Jun"] = "06",
                ["Jul"] = "07",
                ["Aug"] = "08",
                ["Sep"] = "09",
                ["Oct"] = "10",
                ["Nov"] = "11",
                ["Dec"] = "12"
            };

            StringBuilder sbANS = new StringBuilder(splitString[2] + '-'+ dictMonth[splitString[1]] + "-");

            if (splitString[0][1] <= '9' && splitString[0][1] >= '0')
            {
                sbANS.Append(splitString[0][0..2]);
            }
            else
            {
                sbANS.Append('0');
                sbANS.Append(splitString[0][0]);
            }

            return sbANS.ToString();
        }
    }
}

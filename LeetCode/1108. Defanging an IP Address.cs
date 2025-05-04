using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1108
    {
        ////(1108.) Defanging an IP Address (EASY)
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}

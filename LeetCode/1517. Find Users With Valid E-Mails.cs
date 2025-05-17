using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1517
    {
        ////(1517.) Find Users With Valid E-Mails (EASY)
        string SqlQuery =
            @"
                    Select
                        user_id,
                        name,
                        mail
                    From Users
                    Where mail LIKE '[a-zA-Z]%@leetcode.com'
                    and mail NOT LIKE '%[!#()$^%=*@+&]%@leetcode.com'   
                ";
    }
}

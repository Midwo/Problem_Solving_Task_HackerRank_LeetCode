using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1667
    {
        ////(1667.) Fix Names in a Table (EASY)
        string SqlQuery =
                @"
                    Select 
                        user_id,
                        Concat(UPPER(SUBSTRING(name, 1, 1)),LOWER(SUBSTRING(name, 2, LEN(name)))) as name  
                    From Users 
                    order by user_id     
                ";

    }
}

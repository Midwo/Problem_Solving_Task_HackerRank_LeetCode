using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1633
    {
        ////(1633.) Percentage of Users Attended a Contest (EASY)
        string SqlQuery =
                @"
                    Select 
                        contest_id,
                        Round(Count(Distinct user_id)*1.0 / (Select Count(distinct user_id ) from Users)*100,2) as percentage  
                    From Register 
                    Group by contest_id
                    order by percentage desc, contest_id asc  
                ";

    }
}

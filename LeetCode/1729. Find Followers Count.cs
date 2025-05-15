using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1729
    {
        ////(1729.) Find Followers Count (EASY)
        string SqlQuery =
            @"
                Select
                    user_id,
                    Count(*) as followers_count
                From Followers 
                Group by user_id
            ";
    }
}

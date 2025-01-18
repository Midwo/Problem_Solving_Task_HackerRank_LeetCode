using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_196
    {
        ////(196.) Delete Duplicate Emails(EASY)
        string SqlQuery = @"DELETE a
                FROM Person  as a 
                inner join Person  as b
                on a.email = b.email and a.id > b.id";
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_183
    {
        //(183.) Customers Who Never Order (EASY)

        string SqlQuery = @"
                Select 
                a.[name] as [Customers]
                From Customers as a
                left join Orders as b
                on a.id = b.customerId
                where b.id is null
                ";
    }
}

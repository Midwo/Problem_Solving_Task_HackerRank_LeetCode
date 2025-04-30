using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1068
    {
        ////(1068.) Product Sales Analysis I (EASY)

        string SqlQuery =
                @"
                    Select
                        b.product_name,
                        a.year,
                        a.price
                    FROM Sales as a
                    left JOIN Product as b
                    ON a.product_id = b.product_id 
                ";
    }
}

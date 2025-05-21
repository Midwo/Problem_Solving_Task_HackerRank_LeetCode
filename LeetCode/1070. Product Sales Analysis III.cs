using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1070
    {
        ////(1070.) Product Sales Analysis III (MEDIUM)
        string SqlQuery =
            @"
                    Select 
                        a.product_id,
                        a.first_year,
                        a.quantity,
                        a.price
                    FROM
                    (
                        Select
                            product_id,
                            year as first_year,
                            quantity,
                            price,
                            RANK() OVER (PARTITION BY product_id ORDER BY year) AS Rank
                        FROM Sales 
                    ) a
                    Where Rank = 1;
                ";

        //OR
        LeetCode_1070 classLeetCode = new LeetCode_1070();
    }
}

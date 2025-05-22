using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1045
    {
        ////(1045.) Customers Who Bought All Products (MEDIUM)
        string SqlQuery =
            @"
                    With CTE as 
                    (
                        Select
                            Count(distinct product_key) as howMany
                        From Product 
                    )
                    
                    Select
                        customer_id
                    From 
                    (
                        Select
                            customer_id,
                            Count(distinct product_key) as howMany
                        From Customer 
                        Group by customer_id
                    ) as a 
                    Where howMany = (select howMany from CTE)
                ";

        //OR

        LeetCode_1045 classLeetCode = new LeetCode_1045();
    }
}

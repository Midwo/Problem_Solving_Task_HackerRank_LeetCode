using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1327
    {
        /////(1327.) List the Products Ordered in a Period (EASY)
        string SqlQuery =
                @"
                    Select
                        product_name,
                        a.unit
                    From 
                    (
                        Select  
                        product_id,
                        SUM(unit) as unit        
                        From Orders 
                        Where Year(order_date) = 2020 and Month(order_Date) = 2 
                        Group by product_id
                        Having SUM(unit) >= 100
                    ) as a
                    left join Products as b
                    ON a.product_id = b.product_id  
                ";
    }
}

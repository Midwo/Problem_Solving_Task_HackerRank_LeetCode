using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1164
    {
        //(1164.) Product Price at a Given Date (MEDIUM)
        string SqlQuery =
            @"
                 Select 
                     c.product_id,
                     IIF(d.price is null, 10, d.price) as price
                 From
                 (
                     Select
                         distinct product_id
                     From Products
                 ) c
                 left join 
                 (   
                     Select
                         a.product_id,
                         b.new_price as price
                         from 
                         (
                             Select
                                 product_id,
                                 max(change_date) as lastDate
                             From Products 
                             Where change_date <= '2019-08-16'
                             Group by product_id
                         ) a
                         left join Products as b
                         On a.product_id = b.product_id and a.lastDate = b.change_date
                 ) as d
                 On c.product_id = d.product_id
            ";
    }
}

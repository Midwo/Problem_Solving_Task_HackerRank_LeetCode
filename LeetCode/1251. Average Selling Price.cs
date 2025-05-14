using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1251
    {
        ////(1251.) Average Selling Price (EASY)
        string SqlQuery =
            @"
                    Select 
                        c.product_id,
                        IIF(c.average_price is null, 0, c.average_price) as average_price
                    From (
                            Select
                                b.product_id,
                                ROUND(SUM(a.unitAndPrice*1.0)/SUM(a.units*1.0), 2) as average_price 
                            From (
                                    Select
                                        a.product_id, 
                                        a.units * b.price as unitAndPrice,
                                        a.units
                                    From UnitsSold as a
                                    left Join Prices as b
                                    ON a.product_id = b.product_id and a.purchase_date between b.start_date and b.end_date 
                                 ) AS a
                            Right join Prices  as b
                            ON b.product_id = a.product_id
                            Group by b.product_id
                         ) as c   
                ";
    }
}

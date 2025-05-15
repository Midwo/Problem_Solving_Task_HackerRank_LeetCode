using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1174
    {
        ////(1174.) Immediate Food Delivery II (MEDIUM)
        string SqlQuery =
            @"
                    Select
                        ROUND((d.immediate*1.0/d.allDelivery)*100,2) as immediate_percentage
                    From
                    ( 
                        Select
                            --b.customer_id,
                            SUM(IIF(c.order_date = c.customer_pref_delivery_date, 1, 0)) as immediate,
                            COUNT(*) as allDelivery
                        From (
                                Select 
                                a.customer_id,
                                (Select top 1 delivery_id From Delivery Where a.customer_id = customer_id Order by order_date) as firstBuyID
                                From 
                                (   
                                    Select
                                        Distinct customer_id
                                    From Delivery 
                                ) as a
                        ) as b
                        Left join Delivery as c
                        On c.delivery_id  = b.firstBuyID
                    ) as d
                ";
    }
}

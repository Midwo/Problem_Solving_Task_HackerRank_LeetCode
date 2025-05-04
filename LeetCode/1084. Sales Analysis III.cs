using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1084
    {
        ////(1084.) Sales Analysis III (EASY)
        string SqlQuery =
                 @"
                    Select
                        DISTINCT a.product_id,
                        b.product_name 
                    From Sales as a
                    Left Join Product as b
                    ON a.product_id = b.product_id
                    Where a.sale_date between '2019-01-01' and '2019-03-31' and a.product_id Not IN 
                        (Select
                            product_id
                         From Sales 
                         Where sale_date < '2019-01-01' or sale_date > '2019-03-31' )  
                ";
    }
}

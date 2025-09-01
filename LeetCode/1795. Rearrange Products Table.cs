using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1795
    {
        ////(1795) Rearrange Products Table (EASY)
        string SqlQuery =
            @"
                    Select 
                        product_id,
                        'store1' as store,
                        store1 as price 
                    FROM Products
                    Where store1 is not null
                    UNION ALL
                    Select 
                        product_id,
                        'store2' as store,
                        store2 as price 
                    FROM Products 
                    Where store2 is not null
                    UNION ALL
                    Select 
                        product_id,
                        'store3' as store,
                        store3 as price 
                    FROM Products 
                    Where store3 is not null
                ";
    }
}

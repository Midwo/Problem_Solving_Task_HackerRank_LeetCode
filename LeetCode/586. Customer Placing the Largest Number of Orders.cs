using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_586
    {
        ////(586.) Customer Placing the Largest Number of Orders (EASY)

        ////T-SQL query CODE - MS SQL */

        //SELECT
        //customer_number
        //FROM
        //    (
        //        Select
        //        customer_number,
        //        (customer_number) as countCustomer
        //        From Orders
        //        Group BY customer_number
        //    ) as a
        //WHERE countCustomer = (
        //                        Select
        //                        max(countCustomer)
        //                        FROM
        //                        (Select
        //                        customer_number,
        //                        COUNT(customer_number) as countCustomer
        //                        From Orders
        //                        Group BY customer_number
        //                      ) as b)
    }
}

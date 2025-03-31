using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_607
    {
        ////(607.) Sales Person (EASY)

        ////T-SQL query CODE - MS SQL */

        //Select
        //    a.name
        //    FROM SalesPerson as a
        //    Where sales_id NOT IN
        //                       (Select
        //                            a.sales_id
        //                        FROM Orders as a
        //                        INNER JOIN Company as b
        //                        ON b.com_id = a.com_id
        //                        Where b.name = 'RED')
    }
}

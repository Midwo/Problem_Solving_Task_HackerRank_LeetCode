using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0150
    {
        ////150. African Cities (EASY)
        string SqlQuery =
                @"
                    SELECT 
                        A.NAME
                    FROM CITY as A
                    JOIN COUNTRY as B
                    ON A.CountryCode = B.Code
                    WHERE CONTINENT = 'Africa'
                ";

    }
}

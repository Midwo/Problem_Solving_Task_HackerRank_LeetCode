using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0148
    {
        ////148. Weather Observation Station 20 (MEDIUM)
        //string SqlQuery =
        //    @"
        //DECLARE @How_many_records int
        //SET @How_many_records = (
        //                            SELECT 
        //                                MAX(Row#)
        //                            FROM
        //                            (
        //                                SELECT
        //                                    ROW_NUMBER() OVER (ORDER BY[LAT_N] ASC) AS Row#
        //                                FROM [STATION]
        //                            ) as counting_records
        //                         )

        //SELECT
        //    CASE
        //        WHEN
        //            (
        //               SELECT 
        //                    Rows1
        //               FROM
        //               (
        //                   SELECT 
        //                        MAX(Row#) as Rows1
        //                   FROM
        //                       (
        //                            SELECT
        //                            ROW_NUMBER() OVER(ORDER BY[LAT_N] ASC) AS Row#
        //                            FROM[STATION]
        //                       ) as counting_records
        //               ) as counting_records_with_max) % 2 = 0 
        //               THEN
        //                   (
        //                       SELECT
        //                            CAST(SUM([LAT_N]) / 2 as decimal(10, 4)) as mediana
        //                       FROM
        //                           (
        //                               SELECT
        //                                    [LAT_N]
        //                                    ,ROW_NUMBER() OVER(ORDER BY[LAT_N] ASC) AS Row#
        //                               FROM[STATION]

        //                           ) as mediana
        //                       WHERE Row# IN (@How_many_records/2, @How_many_records/2+1))

        //                ELSE
        //                    (
        //                        SELECT
        //                            CAST([LAT_N] as decimal(10, 4)) as mediana
        //                        FROM
        //                            (
        //                                SELECT
        //                                    [LAT_N]
        //                                    ,ROW_NUMBER() OVER(ORDER BY[LAT_N] ASC) AS Row#
        //                                FROM[STATION]

        //                            ) as mediana
        //                        WHERE Row# = ((@How_many_records+1)/2)
        //                    )
        //                    END AS Mediana
        //    ";
    }
}

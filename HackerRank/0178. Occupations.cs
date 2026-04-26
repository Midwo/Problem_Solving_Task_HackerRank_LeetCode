using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0178
    {
        ////178. Occupations (EASY)
        //string SqlQuery =
        //@"
        //    SELECT Doctor
        //    ,Professor
        //    , Singer 
        //    ,Actor
        //    --,Row1#
        //    FROM 
        //    (
        //    SELECT  Doctor, Professor, Singer, Actor, ROW_NUMBER() OVER(ORDER BY [Row#] ) AS Row1#  FROM(
        //    SELECT  Doctor, Professor, Singer, ROW_NUMBER() OVER(ORDER BY [Row#] ) AS Row#  FROM(

        //    SELECT Doctor, Professor
        //    , ROW_NUMBER() OVER(ORDER BY [Row#] ) AS Row# 
        //    FROM
        //    (
        //    (SELECT [NAME] as Doctor, ROW_NUMBER() OVER(ORDER BY [NAME] ASC) AS Row1 FROM [OCCUPATIONS]
        //    WHERE OCCUPATION = 'Doctor') as DoctorsTable
        //    full outer JOIN (SELECT [NAME] as Professor, ROW_NUMBER() OVER(ORDER BY [NAME] asc) AS Row# FROM [OCCUPATIONS]
        //    WHERE OCCUPATION = 'Professor') as ProfessorTable
        //    ON DoctorsTable.[Row1] = ProfessorTable.Row#
        //    )
        //    ) as ok

        //    full JOIN  (SELECT [NAME] as Singer, ROW_NUMBER() OVER(ORDER BY [NAME] asc) AS Row2 FROM [OCCUPATIONS]
        //    WHERE OCCUPATION = 'Singer') as SingerTable
        //    ON ok.Row# = SingerTable.Row2

        //    ) as ok1
        //    full JOIN  (SELECT [NAME] as Actor, ROW_NUMBER() OVER(ORDER BY [NAME] ASC) AS Row3 FROM [OCCUPATIONS]
        //    WHERE OCCUPATION = 'Actor') as ActorTable
        //    ON ok1.Row# = ActorTable.Row3
        //    ) as ok2
        //";    
    }
}

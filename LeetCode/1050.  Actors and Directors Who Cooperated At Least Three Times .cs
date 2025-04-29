using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1050
    {
        ////(1050.) Actors and Directors Who Cooperated At Least Three Times (EASY);
        string SqlQuery =
                @"
                     Select
                        actor_id,
                        director_id
                     FROM (Select
                              actor_id,
                              director_id,
                              count(director_id) as HowMany
                              FROM ActorDirector 
                              GROUP BY  actor_id, director_id) a
                     Where HowMany > 2;
                ";
    }
}

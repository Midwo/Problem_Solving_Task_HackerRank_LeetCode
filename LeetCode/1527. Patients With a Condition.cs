using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1527
    {
        ////(1527.) Patients With a Condition (EASY)
        string SqlQuery =
                @"
                    Select 
                        patient_id,
                        patient_name,
                        conditions
                    From Patients 
                    Where conditions like 'DIAB1%' OR conditions like '% DIAB1%'     
                ";
    }
}

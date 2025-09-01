using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3475
    {
        ////(3475.) DNA Pattern Recognition (MEDIUM)
        string SqlQuery =
                @"
                    SELECT 
                        a.sample_id
                        ,dna_sequence
                        ,species
                        ,EXISTS (SELECT 1 FROM Samples b WHERE LEFT(dna_sequence, 3) =  'ATG' and b.sample_id = a.sample_id) as has_start 
                        ,EXISTS (SELECT 1 FROM Samples b WHERE RIGHT(dna_sequence, 3) IN ('TAA', 'TAG', 'TGA') and b.sample_id = a.sample_id) as has_stop  
                        ,EXISTS (SELECT 1 FROM Samples b WHERE b.dna_sequence  like '%ATAT%' and b.sample_id = a.sample_id) as has_atat
                        ,EXISTS (SELECT 1 FROM Samples b WHERE b.dna_sequence  like '%GGG%' and b.sample_id = a.sample_id) as has_ggg
                    FROM 
                    Samples a 
                ";
    }
}

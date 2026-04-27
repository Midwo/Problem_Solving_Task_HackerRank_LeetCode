using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1275
    {
        ////(1275.) Find Winner on a Tic Tac Toe Game (EASY)
        public string Tictactoe(int[][] moves)
        {
            var table = new char[3][];
            for (int i = 0; i < 3; i++) 
            {
                table[i] = new char[3];
            }

            char nextMove = 'A';
            foreach (var item in moves)
            {
                table[item[0]][item[1]] = nextMove;
                nextMove = nextMove == 'A'? 'B' : 'A';
            }

            if (table[0][0] == 'A' && table[0][1] == 'A' && table[0][2]  == 'A' || table[0][0] == 'B' && table[0][1] == 'B' && table[0][2] == 'B')
                return table[0][0].ToString();
            if (table[1][0] == 'A' && table[1][1] == 'A' && table[1][2] == 'A' || table[1][0] == 'B' && table[1][1] == 'B' && table[1][2] == 'B')
                return table[1][0].ToString();
            if (table[2][0] == 'A' && table[2][1] == 'A' &&  table[2][2] == 'A' || table[2][0] == 'B' && table[2][1] == 'B' && table[2][2] == 'B')
                return table[2][0].ToString();

            if (table[0][0] == 'A' && table[1][0] == 'A' && table[2][0] == 'A' || table[0][0] == 'B' && table[1][0] == 'B' && table[2][0] == 'B')
                return table[0][0].ToString();
            if (table[0][1] == 'A' && table[1][1] == 'A' && table[2][1] == 'A'|| table[0][1] == 'B' && table[1][1] == 'B' && table[2][1] == 'B')
                return table[0][1].ToString();
            if (table[0][2] == 'A' && table[1][2] == 'A' && table[2][2] == 'A' || table[0][2] == 'B' && table[1][2] == 'B' && table[2][2] == 'B')
                return table[0][2].ToString();


            if (table[0][0] == 'A' && table[1][1] == 'A' && table[2][2] == 'A' || table[0][0] == 'B' && table[1][1] == 'B' && table[2][2] == 'B')
                return table[0][0].ToString();
            if (table[2][0] == 'A' && table[1][1] == 'A' && table[0][2] == 'A' || table[2][0] == 'B' && table[1][1] == 'B' && table[0][2] == 'B')
                return table[2][0].ToString();

            if(moves.Length < 9)
                return "Pending";

            return "Draw";
        }
    }
}

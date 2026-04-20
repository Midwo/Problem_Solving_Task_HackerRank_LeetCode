using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0109
    {
        ////109. Strong Password (EASY)
        public  int minimumNumber(int n, string password)
        {
            int minlenght = 6;
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int howManyAdd = 0;


            howManyAdd = !password.Any(numbers.Contains) ? ++howManyAdd : howManyAdd;
            howManyAdd = !password.Any(lower_case.Contains) ? ++howManyAdd : howManyAdd;
            howManyAdd = !password.Any(upper_case.Contains) ? ++howManyAdd : howManyAdd;
            howManyAdd = !password.Any(special_characters.Contains) ? ++howManyAdd : howManyAdd;
            howManyAdd = minlenght > n + howManyAdd ? howManyAdd = minlenght - n : howManyAdd;

            return howManyAdd;
        }
    }
}

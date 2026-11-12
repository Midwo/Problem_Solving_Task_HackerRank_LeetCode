using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_841
    {
        ////(841.) Keys and Rooms (MEDIUM)
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            int countRooms = rooms.Count;
            bool[] visitedRooms = new bool[countRooms];
            int countVisitedRooms = 0;
            CheckRooms(0);

            void CheckRooms(int currRoom)
            {
                if (!visitedRooms[currRoom])
                {
                    visitedRooms[currRoom] = true;
                    countVisitedRooms++;
                    foreach (int newRoom in rooms[currRoom])
                    {
                            CheckRooms(newRoom);
                    }
                }
            }

            return countVisitedRooms == countRooms;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1603
    {
        ////(1603.) Design Parking System (EASY)
        public class ParkingSystem
        {
            private int _big;
            private int _medium;
            private int _small;
            public ParkingSystem(int big, int medium, int small)
            {
                _big = big;
                _medium = medium;   
                _small = small;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case 1:
                        if(_big > 0)
                        {
                            _big--;
                            return true;
                        }
                        return false;
                    case 2:
                        if(_medium > 0)
                        {
                            _medium--;
                            return true;
                        }
                        return false;
                    case 3:
                        if (_small > 0)
                        {
                            _small--;
                            return true;
                        }
                        return false;
                    default:
                        return false;
                }
            }
        }
    }
}

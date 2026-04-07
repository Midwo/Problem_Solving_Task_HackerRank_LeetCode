using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2069
    {
        ////(2069.) Walking Robot Simulation II (MEDIUM)
        public class Robot
        {
            private int _SumModuloSteps;
            private int _SumCircle;
            private int _width;
            private int _height;
            private int _eastMaxSteps;
            private int _northMaxSteps;
            private int _westMaxSteps;
            private int _southMaxSteps;
            private bool _secondCircle;
            public Robot(int width, int height)
            {
                _SumModuloSteps = 0;
                _SumCircle = width + width + height + height - 4;
                _width = width;
                _height = height;
                _eastMaxSteps = width - 1;
                _northMaxSteps = width + height - 2;
                _westMaxSteps = _northMaxSteps + width - 1;
                _southMaxSteps = _westMaxSteps + height - 1;
                _secondCircle = false;
            }

            public void Step(int num)
            {
                _SumModuloSteps += num;
                if(_SumModuloSteps >= num)
                {
                    _secondCircle = true;
                }
                _SumModuloSteps %= _SumCircle;
            }

            public int[] GetPos()
            {
                if (_SumModuloSteps > _westMaxSteps)
                {
                    return new int[] {0, _SumCircle - _SumModuloSteps};
                }
                else if (_SumModuloSteps > _northMaxSteps)
                {
                    return new int[] { _width-1+_width+_height-2-_SumModuloSteps, _height-1 };
                }
                else if (_SumModuloSteps > _eastMaxSteps)
                {
                    return new int[] { _width-1, _SumModuloSteps-_eastMaxSteps };
                }
                else
                {
                    return new int[] { _SumModuloSteps, 0 };
                }
            }

            public string GetDir()
            {
                if(_SumModuloSteps > _westMaxSteps || _SumModuloSteps == 0 && _secondCircle)
                {
                    return "South";
                }
                else if(_SumModuloSteps > _northMaxSteps)
                {
                    return "West";
                }
                else if(_SumModuloSteps > _eastMaxSteps)
                {
                    return "North";
                }
                else
                {
                    return "East";
                }
            }
        }
    }
}

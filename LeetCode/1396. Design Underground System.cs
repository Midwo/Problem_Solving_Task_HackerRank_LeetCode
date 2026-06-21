using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1396
    {
        ////(1396.) Design Underground System (MEDIUM)
        public class UndergroundSystem
        {
            private Dictionary<int, (string, int)> _whoFromTimeStartDictiorany;
            private Dictionary<(string, string), int[]> _routeFromTo;

            public UndergroundSystem()
            {
                _whoFromTimeStartDictiorany = new();
                _routeFromTo = new Dictionary<(string, string), int[]>();
            }

            public void CheckIn(int id, string stationName, int t)
            {
                _whoFromTimeStartDictiorany[id] = (stationName, t);
            }

            public void CheckOut(int id, string stationName, int t)
            {
                (string from, int startTime) = _whoFromTimeStartDictiorany[id];
                if (_routeFromTo.ContainsKey((from, stationName)))
                {
                    _routeFromTo[(from, stationName)][0] += t-startTime;
                    _routeFromTo[(from, stationName)][1]++;
                }
                else
                {
                    _routeFromTo.Add((from, stationName), new int[2] { (t-startTime), 1 } );
                }
            }

            public double GetAverageTime(string startStation, string endStation)
            {
                return (double)_routeFromTo[(startStation, endStation)][0] / _routeFromTo[(startStation, endStation)][1];
            }
        }
    }
}

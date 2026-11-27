using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1195
    {
        ////(1195.) Fizz Buzz Multithreaded (MEDIUM)
        public class FizzBuzz
        {
            private int n;
            private int _counter;
            private SemaphoreSlim _threadFizz;
            private SemaphoreSlim _threadBuzz;
            private SemaphoreSlim _threadFizzBuzz;
            private SemaphoreSlim _threadNumber;

            public FizzBuzz(int n)
            {
                this.n = n;
                _counter = 1;

                _threadFizz = new SemaphoreSlim(0,1);
                _threadBuzz = new SemaphoreSlim(0,1);
                _threadFizzBuzz = new SemaphoreSlim(0,1);
                _threadNumber = new SemaphoreSlim(0,1);
            }

            // printFizz() outputs "fizz".
            public void Fizz(Action printFizz)
            {
                while (_counter <= n) 
                {
                    _threadFizz.Wait();

                    if (_counter > n) break;

                    if (_counter % 3 == 0 && _counter % 5 != 0)
                    {
                        _counter++;
                        printFizz();
                    }
                    
                    _threadNumber.Release();                 
                }
            }

            // printBuzz() outputs "buzz".
            public void Buzz(Action printBuzz)
            {
                while (_counter <= n)
                {
                    _threadBuzz.Wait();

                    if (_counter > n) break;

                    if (_counter % 5 == 0 && _counter % 3 != 0)
                    {
                        _counter++;
                        printBuzz();
                    }

                    _threadNumber.Release();        
                }

            }

            // printFizzBuzz() outputs "fizzbuzz".
            public void Fizzbuzz(Action printFizzBuzz)
            {
                while (_counter <= n)
                {
                    _threadFizzBuzz.Wait();

                    if (_counter > n) break;

                    if (_counter % 5 == 0 && _counter % 3 == 0)
                    {
                        _counter++;
                        printFizzBuzz();
                    }

                     _threadNumber.Release();     
                }
            }

            // printNumber(x) outputs "x", where x is an integer.
            public void Number(Action<int> printNumber)
            {
                while (_counter <= n)
                {
                    if (_counter % 5 != 0 && _counter % 3 != 0)
                    {
                        printNumber(_counter);
                        _counter++;
                    }
                    else if (_counter % 5 == 0 && _counter % 3 == 0)
                    {
                        _threadFizzBuzz.Release();
                        _threadNumber.Wait();
                    }
                    else if (_counter % 5 == 0 && _counter % 3 != 0)
                    {
                        _threadBuzz.Release();
                        _threadNumber.Wait();
                    }
                    else
                    {
                        _threadFizz.Release();
                        _threadNumber.Wait();
                    }
                }
                _threadBuzz.Release();
                _threadFizz.Release();
                _threadFizzBuzz.Release();
            }
        }
    }
}

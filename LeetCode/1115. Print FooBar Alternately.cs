using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1115
    {
        ////(1115.) Print FooBar Alternately (MEDIUM)
        public class FooBar
        {
            private int n;
            private Semaphore _fooStatus;
            private Semaphore _barStatus;

            public FooBar(int n)
            {
                this.n = n;
                _barStatus = new Semaphore(0, n);
                _fooStatus = new Semaphore(0, n);
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n; i++)
                {

                    // printFoo() outputs "foo". Do not change or remove this line.

                    //printFoo();
                    //Local Test:      
                    
                    Console.Write("foo");
                    _barStatus.Release();
                    _fooStatus.WaitOne();

                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n; i++)
                {

                    // printBar() outputs "bar". Do not change or remove this line.
                    _barStatus.WaitOne();
                    //printBar();
                    //Local Test:
                    Console.Write("Bar");
                    _fooStatus.Release();
                }
            }
        }
    }
}

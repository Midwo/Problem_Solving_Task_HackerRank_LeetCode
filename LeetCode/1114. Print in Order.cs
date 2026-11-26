using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1114
    {
        public class Foo
        {

            private EventWaitHandle waitHandle1;
            private EventWaitHandle waitHandle2;

            public Foo()
            {
                waitHandle1 = new AutoResetEvent(false);
                waitHandle2 = new AutoResetEvent(false);
            }

            public void First(Action printFirst)
            {

                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                waitHandle1.Set();
            }

            public void Second(Action printSecond)
            {
                waitHandle1.WaitOne();

                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                waitHandle2.Set();
            }

            public void Third(Action printThird)
            {
                waitHandle2.WaitOne();
                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }
    }
}

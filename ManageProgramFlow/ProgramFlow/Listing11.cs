using System;
using System.Threading;

namespace _70_483.ProgramFlow
{
    public class Listing11
    {
        private void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: " + i + " Called @ :" + DateTime.Now.Millisecond.ToString());
                Thread.Sleep(500);
            }
        }

        public void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work." + DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
            t.Join();
        }
    }
}
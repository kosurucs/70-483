using System;
using System.Threading;

namespace _70_483.ProgramFlow
{
    public class Listing12
    {
        private void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: " + i + " Called @ :" + DateTime.Now.Millisecond.ToString());
                Thread.Sleep(1000);
            }
        }

        public void Main()
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = false;
            t.Start();
        }
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;

namespace _70_483.ManageMultiTheading
{
    public class Listing21
    {
        public void SynchronizingResources()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    n++;
                }
            });

            for (int i = 0; i < 100000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }

        public void SynchronizingResourcesWithLock()
        {
            int n = 0;
            var _lock = new object();
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    lock (_lock)
                        n++;
                }
            });

            for (int i = 0; i < 100000; i++)
            {
                lock (_lock)
                    n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }

        public void SynchronizingResourcesDeadLock()
        {
            var lockA = new object();
            var lockB = new object();

            var up = Task.Run(() => 
            {
                lock(lockA)
                {
                    Thread.Sleep(1000);
                    lock(lockB)
                    {
                        Console.WriteLine("Locked A and B.");
                    }
                }
            });

            lock(lockB)
            {
                lock(lockA)
                {
                    Console.WriteLine("Locked B and A.");
                }
            }

            up.Wait();
        }
    }
}

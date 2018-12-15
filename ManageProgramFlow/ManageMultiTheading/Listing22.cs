using System;
using System.Threading;
using System.Threading.Tasks;

namespace _70_483.ManageMultiTheading
{
    public class Listing22
    {
        private static int _flag = 0;
        private static int _value = 0;

        public void InterLockSharedResources()
        {
            var values = Task.Run(() =>
            {
                _flag = 5;
                _value = 1;
            });

            var value = Task.Run(() =>
            {
                if (_flag == 1)
                    Console.WriteLine(_value);
            });

            Task.WaitAll(values, value);

            Console.ReadLine();
        }

        public void InterLock()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 100000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
        }
    }
}
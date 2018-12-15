using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _70_483.ProgramFlow
{
    public class Listing14
    {
        public void ParallelClass()
        {
            Parallel.For(0, 10, i =>
             {
                 Console.Write(i + "\t");
             });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });
        }

        public void ParallelLoop()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}
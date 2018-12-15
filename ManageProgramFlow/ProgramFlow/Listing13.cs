using System;
using System.Threading;
using System.Threading.Tasks;

namespace _70_483.ProgramFlow
{
    public class Listing13
    {
        public void Main()
        {
            var val = Task.Run(() =>
            {
                return 56;
            }).ContinueWith((values) =>
            {
                Console.WriteLine("values:\t" + values.Result * 2);
            });
        }

        public void ContinuWithDifferentOperation()
        {
            var response = Task.Run(() =>
            {
                return 5 * 6;
            }).ContinueWith(
            (val) =>
            {
                Console.WriteLine("It's cross the Continue Method:\t" + val.Result);
            }, TaskContinuationOptions.None)
            .ContinueWith((res) =>
            {
                Console.WriteLine("It's Scone Level\t" + res.Status.ToString());
            }, TaskContinuationOptions.NotOnCanceled);

            var subResponse = response.ContinueWith((val) =>
            {
                Console.WriteLine("It's Thired Level\t" + val.Status.ToString());
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            subResponse.Wait();
        }

        public void ChildTask()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var results = new Int32[3];
                new Task(() => results[0] = 0,
                TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1,
                TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2,
                TaskCreationOptions.AttachedToParent).Start();
                return results;
            });

            var finalTask = parent.ContinueWith(
            parentTask =>
            {
                foreach (int i in parentTask.Result)
                    Console.WriteLine(i);
            });

            finalTask.Wait();
        }

        public void TaskFactoryMethod()
        {
            try
            {
                var parent = Task.Run(() =>
                {
                    var result = new Int32[3];

                    var tf = new TaskFactory(
                        TaskCreationOptions.AttachedToParent,
                        TaskContinuationOptions.ExecuteSynchronously);
                    tf.StartNew(() => result[0] = 0);
                    tf.StartNew(() => result[1] = 1);
                    tf.StartNew(() => result[2] = 2);

                    return result;
                });

                var child = parent.ContinueWith((result) =>
                {
                    foreach (var val in result.Result)
                    {
                        Console.WriteLine("Values from Parent Task:\t" + val);
                    }
                });

                child.Wait();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }

        public void MultipleTaskWithWaitAll()
        {
            var tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Task [0] Iteration:\t" + i);
                    Thread.Sleep(100);
                }
            });

            tasks[1] = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Task [1] Iteration:\t" + i);
                    Thread.Sleep(50);
                }
            });

            tasks[2] = Task.Run(() =>
            {
                Console.WriteLine("Task [2] Iteration \t");
            });

            Task.WaitAll(tasks);
        }
    }
}
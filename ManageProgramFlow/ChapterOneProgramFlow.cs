using _70_483.EventsAndCallBacks;
using _70_483.ExceptionHandling;
using _70_483.ManageMultiTheading;
using _70_483.multithreadingAndAsynchronous;
using _70_483.ProgramFlow;
using System;

namespace _70_483
{
    public class ChapterOneProgramFlow
    {
        public void ProgramFlowIndex()
        {
            Console.WriteLine("Chapter One Index");
            Console.WriteLine("======================");
            Console.WriteLine("1. Implement Multithreading and asynchronous processing");
            Console.WriteLine("2. Manage Multithreading");
            Console.WriteLine("3. Implement Program flow");
            Console.WriteLine("4. Create And Implement events and callbacks");
            Console.WriteLine("5. Implement exception handing");
            Console.WriteLine("======================");
            Console.WriteLine("Enter your Choice ::");

            var index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:
                    ProgramFlow();
                    break;

                case 2:
                    ManageMultiThreading();
                    break;

                case 3:
                    MultiThreadingAndAsynchronous();
                    break;

                case 4:
                    EventsAndCallBacks();
                    break;

                default:
                    break;
            }

        }

        public static void ProgramFlow()
        {
            Console.WriteLine("1. Listing 11");
            Console.WriteLine("2. Listing 12");
            Console.WriteLine("3. Listing 13");
            Console.WriteLine("4. Listing 14");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var OneAndOne = new Listing11();
                    OneAndOne.Main();
                    Console.ReadKey();
                    break;

                case 2:
                    var OneAndTwo = new Listing12();
                    OneAndTwo.Main();
                    Console.ReadKey();
                    break;

                case 3:
                    var OneAndThree = new Listing13();
                    OneAndThree.Main();
                    OneAndThree.ContinuWithDifferentOperation();
                    OneAndThree.ChildTask();
                    OneAndThree.TaskFactoryMethod();
                    OneAndThree.MultipleTaskWithWaitAll();
                    break;

                case 4:
                    var OneAndFour = new Listing14();
                    OneAndFour.ParallelClass();
                    OneAndFour.ParallelLoop();
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }

        public static void ManageMultiThreading()
        {
            Console.WriteLine("1. Listing 21");
            Console.WriteLine("2. Listing 22");
            Console.WriteLine("3. Listing 23");
            Console.WriteLine("4. Listing 24");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var TwoAndOne = new Listing21();
                    TwoAndOne.SynchronizingResources();
                    TwoAndOne.SynchronizingResourcesWithLock();
                    TwoAndOne.SynchronizingResourcesDeadLock();

                    break;
                case 2:
                    var TwoAndTwo = new Listing22();
                    TwoAndTwo.InterLockSharedResources();
                    TwoAndTwo.InterLock();
                    break;

                default:
                    break;
            }
        }

        public static void MultiThreadingAndAsynchronous()
        {
            Console.WriteLine("1. Shor-Circute");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var Shot_Circute = new BooleanExpressions();
                    Shot_Circute.BooleanStements_Or();
                    Shot_Circute.BooleanStements_ExclusiveOr();
                    Shot_Circute.SwitchStatement();
                    Shot_Circute.ForStatement();
                    Shot_Circute.JumpStatement();
                    break;

                default:
                    break;
            }
        }

        public static void EventsAndCallBacks()
        {
            Console.WriteLine("1. Delegates");
            Console.WriteLine("2. Events And Actions");
            Console.WriteLine("3. Exception Handling");

            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    var delegateExample = new DelegateExamples();
                    var add = new GetValues(delegateExample.Add);
                    Console.WriteLine(add(10, 56));
                    var mul = new GetValues(delegateExample.Mul);
                    Console.WriteLine(mul(10, 56));
                    break;

                case 2:
                    var EventsAndAction = new EventsAndActions();
                    EventsAndAction.CreateAndRaise();
                    EventsAndAction.CreateAndRaiseWithEvent();
                    EventsAndAction.CreateAndRaiseWithEventHandler();
                    break;

                case 3:
                    var exceptionHander = new ExceptionHandlingMethods();
                    exceptionHander.NullException();
                    break;

                default:
                    break;
            }
        }
    }
}
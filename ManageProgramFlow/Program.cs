using _70_483.EventsAndCallBacks;
using _70_483.ExceptionHandling;
using _70_483.ManageMultiTheading;
using _70_483.multithreadingAndAsynchronous;
using _70_483.ProgramFlow;
using System;

namespace _70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            LableValues();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Do you want repeate Loop Again? YES -1 /NO - 0");
                var value = Convert.ToInt32(Console.ReadLine());
                if (value == 0)
                {
                    break;

                }
                LableValues();
            }
        }

        public static void LableValues()
        {
            Console.WriteLine("========= // 70-483 \\=======");
            Console.WriteLine("Objective 1: Implement multithreading and Asynchronous processing");
            Console.WriteLine("Objective 2: Manage Multithreading");
            Console.WriteLine("Objective 3: Implement Program Flow.");
            Console.WriteLine("Objective 4: Events and Call Backs.");

            Console.WriteLine("========= // 70-483 \\=======");
            Console.WriteLine("Enter your Choice ::");

            var option = Convert.ToInt32(Console.ReadLine());
            DoItBasedOnObject(option);
        }

        public static void DoIt()
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

        public static void DoItForObject2()
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

        public static void DoItProgramFlow()
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

        public static void DoItBasedOnObject(int objectiveValue)
        {
            switch (objectiveValue)
            {
                case 1:
                    DoIt();
                    break;

                case 2:
                    DoItForObject2();
                    break;

                case 3:
                    DoItProgramFlow();
                    break;
                case 4:
                    DoItEvents();
                    break;

                default:
                    break;
            }
        }

        public static void DoItEvents()
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

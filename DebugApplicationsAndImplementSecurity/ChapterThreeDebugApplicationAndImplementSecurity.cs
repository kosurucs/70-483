using System;

namespace DebugApplicationsAndImplementSecurity
{
    public class ChapterThreeDebugApplicationAndImplementSecurity
    {
        public void DebugApplicationAndImplementSecurityIndex()
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
                    // ProgramFlow();
                    break;

                case 2:
                    // ManageMultiThreading();
                    break;

                case 3:
                    // MultiThreadingAndAsynchronous();
                    break;

                case 4:
                    // EventsAndCallBacks();
                    break;

                default:
                    break;
            }
        }
    }
}
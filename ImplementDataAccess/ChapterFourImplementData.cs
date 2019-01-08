using System;

namespace ImplementDataAccess
{
    public class ChapterFourImplementData
    {
        public void ImplementDataIndex()
        {
            Console.WriteLine("Chapter One Index");
            Console.WriteLine("======================");
            Console.WriteLine("1. PerformIO-Operation.");
            Console.WriteLine("2. Consume Data.");
            Console.WriteLine("3. Query and Manipulate Data and Objects by Using LINQ.");
            Console.WriteLine("4. Serialize and Deserialize data.");
            Console.WriteLine("5. Store data in and Retrieve Data from Collections.");
            Console.WriteLine("======================");
            Console.WriteLine("Enter your Choice ::");

            var index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:
                    //ProgramFlow();
                    break;

                case 2:
                    ////ManageMultiThreading();
                    break;

                case 3:
                    //MultiThreadingAndAsynchronous();
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
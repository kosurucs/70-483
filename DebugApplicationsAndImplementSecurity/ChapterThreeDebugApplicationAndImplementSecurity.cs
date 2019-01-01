using DebugApplicationsAndImplementSecurity.ValidateApplicationInput;
using System;

namespace DebugApplicationsAndImplementSecurity
{
    public class ChapterThreeDebugApplicationAndImplementSecurity
    {
        public void DebugApplicationAndImplementSecurityIndex()
        {
            Console.WriteLine("Chapter One Index");
            Console.WriteLine("======================");
            Console.WriteLine("1. Validate Application Input");
            Console.WriteLine("2. Perform Symmantic and Asymmantic Encryption.");
            Console.WriteLine("3. Manage Assamblies");
            Console.WriteLine("4. Debug Application");
            Console.WriteLine("5. Implement Diagnostics in Application.");
            Console.WriteLine("======================");
            Console.WriteLine("Enter your Choice ::");

            var index = Convert.ToInt32(Console.ReadLine());
            switch (index)
            {
                case 1:
                    var validateInputs = new ValidateInputs();
                    validateInputs.Run();
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
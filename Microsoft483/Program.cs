using _70_483;
using CreateAndUseTypes;
using DebugApplicationsAndImplementSecurity;
using ImplementDataAccess;
using System;

namespace Microsoft483
{
    internal class Program
    {
        private static void Main(string[] args)
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
            Console.WriteLine("Chapter 1: Manage Program Flow.");
            Console.WriteLine("Chapter 2: Create And Use Types.");
            Console.WriteLine("Chapter 3: Debug Applications And Implement Security.");
            Console.WriteLine("Chapter 4: Implement Data Access.");
            Console.WriteLine("========= // 70-483 \\=======");
            Console.WriteLine("Enter your Choice ::");

            var option = Convert.ToInt32(Console.ReadLine());
            Index(option);
        }

        public static void Index(int index)
        {
            switch (index)
            {
                case 1:
                    var chapterOneProgramFlow = new ChapterOneProgramFlow();
                    chapterOneProgramFlow.ProgramFlowIndex();
                    break;

                case 2:
                    var chapterTwoCreateAndUseType = new ChapterTwoCreateAndUseType();
                    chapterTwoCreateAndUseType.CreateAndUseTypeIndex();
                    break;

                case 3:
                    var chapterThreeDebugApplicationAndImplementSecurity = new ChapterThreeDebugApplicationAndImplementSecurity();
                    chapterThreeDebugApplicationAndImplementSecurity.DebugApplicationAndImplementSecurityIndex();
                    break;

                case 4:
                    var chapterFourImplementData = new ChapterFourImplementData();
                    chapterFourImplementData.ImplementDataIndex();
                    break;

                default:
                    break;
            }
        }
    }
}
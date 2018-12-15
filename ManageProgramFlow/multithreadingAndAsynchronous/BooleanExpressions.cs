using System;

namespace _70_483.multithreadingAndAsynchronous
{
    public class BooleanExpressions
    {
        public void BooleanStements_Or()
        {
            var x = true;
            var y = x || GetVal();

            Console.WriteLine(y);
            Console.ReadLine();
        }

        public void BooleanStements_ExclusiveOr()
        {
            var x = true;
            var y = x ^ GetVal();

            Console.WriteLine(y);
            Console.ReadLine();
        }

        public void SwitchStatement()
        {
            int i = 1;

            switch (i)
            {
                case 1:
                    Console.WriteLine(" Case One executed");
                    goto case 2;

                case 2:
                    Console.WriteLine(" Case Two Executed");
                    goto default;

                default:
                    Console.WriteLine("Default Statement");
                    break;
            }
        }

        public void ForStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) continue;
                Console.Write(values[index] + "\t");
            }
        }

        public void JumpStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) goto customer;
                Console.Write(values[index]);
            }

            customer:
            Console.WriteLine("Result finally");
        }

        private bool GetVal()
        {
            Console.WriteLine("It's True Value");
            return false;
        }
    }
}
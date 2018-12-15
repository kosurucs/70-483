using System;

namespace _70_483.ExceptionHandling
{
    public class ExceptionHandlingMethods
    {
        public void NullException()
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) break;
                try
                {
                    int i = int.Parse(s);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0} is not a valid number. Please try again", s);
                }
            }
        }
    }
}
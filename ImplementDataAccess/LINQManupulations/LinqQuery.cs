using System;
using System.Linq;

namespace ImplementDataAccess.LINQManupulations
{
    public class LinqQuery
    {
        Action<int, int> Add = (int a, int b) => { Console.WriteLine(" Multiplication :\t" + a + b); };
        Action<string> DisplayChar = (string name) =>
          {
              if (name != null)
              {
                  foreach (var ch in name.ToArray())
                  {
                      Console.Write(ch + "\t");
                  }
              }
          };

        Func<int, int, int> Mul = delegate (int c, int e) { return c * e; };
    }
}

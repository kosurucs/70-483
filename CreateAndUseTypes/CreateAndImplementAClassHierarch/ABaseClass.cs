using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUseTypes.CreateAndImplementAClassHierarch
{
    public class ABaseClass
    {
        public void Display()
        {
            Console.WriteLine("A Base Class.");
        }

        public virtual void DisplayWithVirtual()
        {
            Console.WriteLine("A Base Class.");
        }
    }
}

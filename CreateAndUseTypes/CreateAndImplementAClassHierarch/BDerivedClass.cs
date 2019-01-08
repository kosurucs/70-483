using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUseTypes.CreateAndImplementAClassHierarch
{
    public class BDerivedClass : ABaseClass
    {
        public new void Display()
        {
            Console.WriteLine("B Derived Class");
        }

        public override void DisplayWithVirtual()
        {
            Console.WriteLine("B Derived Class");
        }
    }
}

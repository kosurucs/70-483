using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUseTypes.CreateAndImplementAClassHierarch
{
    interface IExample
    {
        string GetResult();
        int Value { get; set; }
        event EventHandler ResultRetrieved;
        int this[string index] { get; set; }
    }
}

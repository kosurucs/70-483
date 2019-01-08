using System;

namespace CreateAndUseTypes.CreateAndImplementAClassHierarch
{
    public abstract class ASampleClass
    {
        protected abstract string display();
    }

    public class SampleClass : ASampleClass
    {
        protected override string display()
        {
            throw new NotImplementedException();
        }
    }
}
